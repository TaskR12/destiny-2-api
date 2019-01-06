using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Destiny2.Api.Model.Definitions;
using Destiny2.Api.Model;
using System.Linq.Expressions;
using Destiny2.Api.Model.Definitions.Milestones;
using TestConsole.Extensions;
using static Destiny2.Api.Model.Enums;

namespace TestConsole
{
    public class UserMilestone
    {
        public DestinyMilestoneDefinition Milestone { get; set; }
        public IEnumerable<DestinyInventoryItemDefinition> Rewards { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public bool Completed { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var cacheProvider = ManifestCacheProvider.Instance;
            var f = new FileInfo(@"C:\Users\Thomas\source\repos\TestConsole\TestConsole\bin\Debug\manifest\mobileWorldContentPathsManifest_fr_20183828-093828.db");
            cacheProvider.LoadManifestFromFile(f.FullName);

            var milestoneRaid = ManifestCacheProvider.Instance.GetDefinitionFromCache<DestinyMilestoneDefinition>(2986584050);
            var engramitem = ManifestCacheProvider.Instance.GetDefinitionFromCache<DestinyInventoryItemDefinition>(4039143015);
            var rwds = milestoneRaid.Rewards;
            var act = milestoneRaid.GetActivities();
            var rwdsact = act.Select(a => a.GetRewards());
            var jokobzWarlock = Destiny2RestApi.Instance
                .GetCharacterByAccountAndClass(
                    EBungieMembershipType.TigerBlizzard, 
                    "Jokobz#21331", 
                    EDestinyClass.Warlock, 
                    new int[] { 100, 200, 202, 204, 205 });

            var milestonesUser = jokobzWarlock.Progressions.Data.Milestones.Select(dct => dct.Value);
            var listMilestones = new List<UserMilestone>();
            var milestonesUserList = new List<UserMilestone>();

            foreach(var mu in milestonesUser)
            {
                var userms = new UserMilestone()
                {
                    Start = mu.StartDate,
                    End = mu.EndDate,
                };
                var ms = ManifestCacheProvider.Instance.GetDefinitionFromCache<DestinyMilestoneDefinition>(mu.MilestoneHash);
                Console.WriteLine("Milestone : " + ms.ToString());
                userms.Milestone = ms;
                var activities = mu.Activities;
                if (activities == null) continue;
                foreach(var actMu in activities)
                {
                    var aa = ManifestCacheProvider.Instance.GetDefinitionFromCache<DestinyActivityDefinition>(actMu.ActivityHash);
                    Console.WriteLine("   Activity : " + aa.DisplayProperties.Name);

                    var rewds = aa.GetRewards();
                    foreach(var rewd in rewds)
                    {
                        Console.WriteLine("         Reward : " + rewd.DisplayProperties.Name);
                    }
                }

                var msRewards = ms.GetRewards();
                Console.WriteLine("--------------------------------------");
                foreach(var item in msRewards)
                {
                    Console.WriteLine("    {0} : {1}", item.DisplayProperties.Name, item.DisplayProperties.Description);
                }

                Console.WriteLine("--------------------------------------");
                Console.WriteLine("-- END OF MILESTONE --");

                
                //var rewards = mu?.Rewards?.SelectMany(rw => rw.Entries);
                //var rewardsList = new List<DestinyInventoryItemDefinition>();

                //if (rewards != null) { 

                //    foreach(var reward in rewards)
                //    {
                //        var rw = ManifestCacheProvider.Instance.GetDefinitionFromCache<DestinyInventoryItemDefinition>(reward.RewardEntryHash);
                //        rewardsList.Add(rw);
                //    }

                //    userms.Rewards = rewardsList;
                //}
                //milestonesUserList.Add(userms);
            }

            var vendors = ManifestCacheProvider.Instance.GetAllDefinitionsFromCache<DestinyVendorDefinition>();
            // Physical vendors
            var types = vendors.Where(v => !string.IsNullOrEmpty(v.VendorIdentifier));

            // To do from vendors => Get items + get those with quests & reward as engrams



            //var act = cacheProvider.GetAllDefinitionsFromCache<DestinyActivityDefinition>();
            var milestones = cacheProvider.GetAllDefinitionsFromCacheWhere<DestinyMilestoneDefinition>(ml => ml.MilestoneType == Enums.EDestinyMilestoneType.Weekly || ml.MilestoneType == Enums.EDestinyMilestoneType.Daily);
            foreach(var milestone in milestones)
            {
                Console.WriteLine("{0} : {1}", milestone.DisplayProperties.Name, milestone.DisplayProperties.Description);

                var rewards = milestone.Rewards?.Values;
                if (rewards == null) continue;
                var items = rewards.SelectMany(r => r.RewardEntries.Values)?.SelectMany(elt => elt.Items);

                Console.WriteLine("Rewards : ----------------------------------");
                foreach (var a in items)
                {
                    var item = ManifestCacheProvider.Instance.GetDefinitionFromCache<DestinyInventoryItemDefinition>(a.ItemHash);
                    Console.WriteLine(item.DisplayProperties.Name + " : " + item.DisplayProperties.Description);
                }
                Console.WriteLine("---------------------------------------------");



                //var milestoneActivities = milestone.GetActivities();

                //foreach(var msActivity in milestoneActivities)
                //{
                //    Console.WriteLine("  {0} : {1} Rewards : ", msActivity.DisplayProperties.Name, msActivity.Rewards.Count());
                //    foreach(var item in msActivity.GetRewards())
                //    {
                //        Console.WriteLine("       {0} ({1}) : {2}", item.DisplayProperties.Name, item.ItemTypeAndTierDisplayName, item.DisplayProperties.Description);
                //    }
                //}
            }
            
            //var modelCharacter = characterFactory.GetCharacter(jokobzWarlock);

            var manifestPath = "https://www.bungie.net/common/destiny2_content/sqlite/fr/world_sql_content_de43f16e9ee92cda3a2ddd64d55dca17.content";
            //using (var client = new WebClient())
            //{
            //    client.DownloadFile(manifestPath, "manifestTest.content");
            //}

            //System.IO.Compression.ZipFile.ExtractToDirectory("manifestTest.content", ".");

            var conn = new SQLiteConnection("Data Source=world_sql_content_de43f16e9ee92cda3a2ddd64d55dca17.db");
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            var mainCache = new Dictionary<Type, IEnumerable<object>>();

            try
            {
                conn.Open();  //Initiate connection to the db
                string cmdTxt = "SELECT name FROM sqlite_master WHERE type='table'";
                ad = new SQLiteDataAdapter(cmdTxt,conn);
                ad.Fill(dt); //fill the datasource

                

                foreach(DataRow table in dt.Rows)
                {
                    DataTable dt2 = new DataTable();
                    var tblName = table["name"].ToString();
                    Console.WriteLine("Reading table " + tblName);
                    var cmd = string.Format("SELECT * FROM {0}", tblName);
                    var ad2 = new SQLiteDataAdapter(cmd, conn);
                    ad2.Fill(dt2); //fill the datasource
                    Type bar = Type.GetType(string.Format("TestConsole.Components.Definitions.{0},TestConsole", tblName));
                    
                    if(bar == null)
                    {
                        Console.WriteLine("Cannot find definition for type {0}", tblName);
                        continue;
                    }

                    var tmpList = new List<object>();

                    foreach (DataRow item in dt2.Rows)
                    {
                        var json = item["json"] as byte[];
                        var baz = new DestinyStatDefinition();
                        var str = System.Text.Encoding.UTF8.GetString(json);
                        var foo = JsonConvert.DeserializeObject(str,bar);
                        tmpList.Add(foo);
                        Console.WriteLine(string.Format("{0} : {1}", item["id"].ToString(), foo.ToString()));
                    }

                    mainCache[bar] = tmpList;
                }
            }
            catch (SQLiteException ex)
            {
                //Add your exception code here.
            }
            conn.Close();

            var lstObjects = mainCache[typeof(DestinyInventoryItemDefinition)];
            var typed = lstObjects.Cast<DestinyInventoryItemDefinition>();
            //var engrams = typed.Where(x => x.ItemType == Enums.EDestinyItemType.Engram);



            //var user = d2Api.SearchDestinyPlayer(Components.Characters.EBungieMembershipType.TigerBlizzard, "Jokobz#21331").First();

            //var profile = d2Api.GetProfile(Components.Characters.EBungieMembershipType.TigerBlizzard, user.MembershipId, new int[] { 100, 200, 204 });
            //var profilePada = d2Api.GetProfile(Components.Characters.EBungieMembershipType.TigerBlizzard, 4611686018484848694, new int[] { 100, 200, 204 });

            //var higherProfileJokobz = d2Api.GetCharacter(user.MembershipType, user.MembershipId, profile.Characters.Data.Last().Value.CharacterId, new int[] { 200,205 });
            //var jokobzStuff = new List<Item>();

            //var itemFactory = new ItemFactory();

            //var stuff = higherProfileJokobz.Equipment.Data.Items.Select(elt => itemFactory.GetItem(higherProfileJokobz.Character.Data.MembershipType, higherProfileJokobz.Character.Data.MembershipId, elt.ItemHash, (long)elt.ItemInstanceId));

            //foreach (var item in stuff)
            //{
            //    Console.WriteLine(item.ToString());
            //}
        }


        public static T Deserialize<T>(byte[] data) where T : class
        {
            using (var stream = new MemoryStream(data))
            using (var reader = new StreamReader(stream, Encoding.UTF8))
                return JsonSerializer.Create().Deserialize(reader, typeof(T)) as T;
        }




    }
}
