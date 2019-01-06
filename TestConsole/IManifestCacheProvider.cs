using Destiny2.Api.Model.Definitions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;

namespace TestConsole
{
    public interface IManifestCacheProvider
    {
        IDictionary<Type,IEnumerable<object>> Cache { get; set; }

        FileInfo RetrieveManifest(string manifestTempFolderCopy, string locale);

        bool LoadManifestToCache(FileInfo dbFile);

        T GetDefinitionFromCache<T>(long hash) where T:IDefinition;

        IEnumerable<T> GetDefinitionsFromCache<T>(long[] hashes) where T : IDefinition;

        IEnumerable<T> GetAllDefinitionsFromCache<T>() where T : IDefinition;

        IEnumerable<T> GetAllDefinitionsFromCacheWhere<T>(Expression<Func<T, bool>> predicate) where T : IDefinition;

        bool CleanupCache();
    }
}
