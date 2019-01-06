using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions;

namespace TestConsole
{
    public class ManifestCacheProvider : IManifestCacheProvider
    {
        public IDictionary<Type, IEnumerable<object>> Cache { get; set; }

        public bool LoadManifestAtInstanciation { get; set; }

        public bool CacheIsInitialized { get; private set; }

        private FileInfo DbFile { get; set; }
        private SQLiteManifestDatabaseReader ManifestReader { get; set; }

        private static ManifestCacheProvider _instance = null;

        public static ManifestCacheProvider Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ManifestCacheProvider();
                }

                return _instance;
            }
        }


        public ManifestCacheProvider()
        {
            CacheIsInitialized = false;
            Cache = new Dictionary<Type, IEnumerable<object>>();
        }

        public void LoadManifestFromRemote()
        {
            var manifestFile = RetrieveManifest("manifest", "fr");
            LoadManifestFromFile(manifestFile.FullName);
        }

        public void LoadManifestFromFile(string dbFilePath)
        {
            CacheIsInitialized = false;
            Cache = new Dictionary<Type, IEnumerable<object>>();
            DbFile = new FileInfo(dbFilePath);
            ManifestReader = new SQLiteManifestDatabaseReader(DbFile);
            LoadManifestToCache(DbFile);
        }

        public bool CleanupCache()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllDefinitionsFromCache<T>() where T:IDefinition
        {
            var type = typeof(T);
            if (!CacheIsInitialized) throw new Exception("Cache not initialized, initialize it first");

            if (Cache.ContainsKey(type)) return Cache[type].Cast<T>();
            return null;
        }


        public IEnumerable<T> GetAllDefinitionsFromCacheWhere<T>(Expression<Func<T, bool>> predicate) where T:IDefinition
        {
            return GetAllDefinitionsFromCache<T>().AsQueryable().Where(predicate);
        }

        public T GetDefinitionFromCache<T>(long hash) where T:IDefinition
        {
            var items = GetAllDefinitionsFromCache<T>();
            return items.FirstOrDefault(item => item.Hash == hash);
        }


        public IEnumerable<T> GetDefinitionsFromCache<T>(long[] hashes) where T : IDefinition
        {
            var items = GetAllDefinitionsFromCache<T>();
            return items.Where(item => hashes.Contains(item.Hash));
        }

        public bool LoadManifestToCache(FileInfo dbFile)
        {
            var tableNames = ManifestReader.GetTableNames();
            foreach(var tableName in tableNames)
            {
                try
                {
                    var type = Utils.FindSubClassOf<Definition>(tableName);
                    var dataFromManifest = ManifestReader.ReadManifestTable(tableName);

                    Cache[type] = dataFromManifest.Cast<IDefinition>();
                }
                catch { }
            }

            CacheIsInitialized = true;
            return true;
        }

        public FileInfo RetrieveManifest(string manifestTempFolderCopy, string locale)
        {
            var destinationFolder = new DirectoryInfo(manifestTempFolderCopy);
            if(!destinationFolder.Exists) Directory.CreateDirectory(destinationFolder.FullName);
            var destinationFileName = string.Format("mobileWorldContentPathsManifest_{0}_{1}", locale, DateTime.Now.ToString("yyyymmdd-hhmmss"));

            // Download the .content file (zip)
            using (var client = new WebClient())
            {
                client.DownloadFile(Destiny2RestApi.Instance.GetManifestUri(locale), $"{destinationFileName}.content");
            }

            // Unzip it in a temp folder
            var dir = Directory.CreateDirectory(Path.Combine(destinationFolder.FullName, "tmp_extract"));
            System.IO.Compression.ZipFile.ExtractToDirectory($"{destinationFileName}.content", dir.FullName);
            var fileTarget = dir.EnumerateFiles("*.content").First();

            // Move back to dest folder & delete temp folder
            File.Copy(fileTarget.FullName, Path.Combine(destinationFolder.FullName, $"{destinationFileName}.db"));
            dir.Delete(true);

            return new FileInfo(Path.Combine(destinationFolder.FullName, $"{destinationFileName}.db"));
        }
    }
}
