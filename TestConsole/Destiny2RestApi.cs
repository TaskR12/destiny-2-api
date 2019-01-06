using Destiny2.Api.Model.Components.Config;
using Destiny2.Api.Model.Definitions;
using Destiny2.Api.Model.Inventory;
using Destiny2.Api.Model.Responses;
using Destiny2.Api.Model.User;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using TestConsole.Responses;
using static Destiny2.Api.Model.Enums;

namespace TestConsole
{

    public class Destiny2RestApi
    {

        private Dictionary<string, IDefinition> DefinitionsCache;

        public readonly string BaseForManifestUri = "https://www.bungie.net/";
        private static Destiny2RestApi _instance = null;

        public static Destiny2RestApi Instance
        {
            get
            {
                if (_instance == null) _instance = new Destiny2RestApi();
                return _instance;
            }
        }

        private readonly Destiny2RestClient client;

        private Destiny2RestApi()
        {
            client = new Destiny2RestClient("c71b0b2224ec4f259a2d61121e2d839d");
            DefinitionsCache = new Dictionary<string, IDefinition>();
        }

        public IEnumerable<UserInfoCard> SearchDestinyPlayer(EBungieMembershipType membership, string displayName)
        {
            var request = new RestRequest("SearchDestinyPlayer/{membership}/{accountName}", Method.GET);

            request.AddUrlSegment("membership", (int)membership);
            request.AddUrlSegment("accountName", displayName);

            return client.Execute<ApiResponse<IEnumerable<UserInfoCard>>>(request).Response;
        }

        /// <summary>
        /// Retrieve profiles based on the display name of the account
        /// </summary>
        /// <param name="membership"></param>
        /// <param name="displayName"></param>
        /// <param name="components"></param>
        /// <returns></returns>
        public IEnumerable<DestinyProfileResponse> GetProfile(EBungieMembershipType membership, string displayName, int[] components)
        {
            var profiles = SearchDestinyPlayer(membership, displayName);
            return profiles.Select(prof => GetProfile(membership, prof.MembershipId, components));
        }

        public DestinyProfileResponse GetSingleProfile(EBungieMembershipType membership, string displayName, int[] components)
        {
            var profiles = SearchDestinyPlayer(membership, displayName);
            if(profiles.Count() != 1)
            {
                throw new System.Exception("More than one profile found or no profil found, cannot return single profile");
            }

            return GetProfile(membership, profiles.First().MembershipId, components);
        }

        public DestinyProfileResponse GetProfile(EBungieMembershipType membership, long membershipId, int[] components)
        {
            var request = new RestRequest("{membership}/Profile/{membershipId}/?components={components}");
            request.AddUrlSegment("membership", (int)membership);
            request.AddUrlSegment("membershipId", membershipId);
            request.AddUrlSegment("components", string.Join(",", components));

            return client.Execute<ApiResponse<DestinyProfileResponse>>(request).Response;
        }

        public DestinyCharacterResponse GetCharacterByAccountAndClass(EBungieMembershipType membership, string displayName, EDestinyClass characterClass, int[] components)
        {
            var character = GetSingleProfile(membership, displayName, components).Characters.Data.FirstOrDefault(ch => ch.Value.ClassType == characterClass).Value;
            // We call again API to get full definition of character (including stuff and not only "basic definition")s
            return GetCharacter(membership, character.MembershipId, character.CharacterId, components);

        }

        public DestinyCharacterResponse GetCharacter(EBungieMembershipType membership, long membershipId, long characterId, int[] components)
        {
            var request = new RestRequest("{membership}/Profile/{membershipId}/Character/{characterId}/?components={components}");
            request.AddUrlSegment("membership", (int)membership);
            request.AddUrlSegment("membershipId", membershipId);
            request.AddUrlSegment("characterId", characterId);
            request.AddUrlSegment("components", string.Join(",", components));

            return client.Execute<ApiResponse<DestinyCharacterResponse>>(request).Response;
        }

        public DestinyCharacterResponse GetCharacter(int membership, long membershipId, long characterId, int[] components)
        {
            return GetCharacter((EBungieMembershipType)membership, membershipId, characterId, components);
        }

        /// <summary>
        /// Return an item from a character
        /// </summary>
        /// <param name="membership"></param>
        /// <param name="membershipId"></param>
        /// <param name="instanceId"></param>
        /// <param name="components"></param>
        /// <returns></returns>
        public InstanciatedItemComponent GetItem(EBungieMembershipType membership, long membershipId, long instanceId, int[] components)
        {
            var request = new RestRequest("{membership}/Profile/{membershipId}/Item/{instanceId}/?components={components}");
            request.AddUrlSegment("membership", (int)membership);
            request.AddUrlSegment("membershipId", membershipId);
            request.AddUrlSegment("instanceId", instanceId);
            request.AddUrlSegment("components", string.Join(",", components));

            return client.Execute<ApiResponse<InstanciatedItemComponent>>(request).Response;

        }

        /// <summary>
        /// Returns a definition through the manifest API
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="hash"></param>
        /// <returns></returns>
        public T GetDefinition<T>(long hash) where T:Definition,new()
        {
            // Check if definition is cached, if so we return it immediatly
            var cachedKeyExpected = string.Format("{0}_{1}", typeof(T).Name, hash);
            if (DefinitionsCache.ContainsKey(cachedKeyExpected)) return DefinitionsCache[cachedKeyExpected] as T;

            // If not we request Api to get definition
            var request = new RestRequest("Manifest/{entityType}/{hashIdentifier}/");
            request.AddUrlSegment("entityType", typeof(T).Name);
            request.AddUrlSegment("hashIdentifier", hash);

            return client.Execute<ApiResponse<T>>(request).Response;
        }

        public string GetManifestUri(string locale)
        {
            var request = new RestRequest("Manifest/");
            var response = client.Execute<ApiResponse<DestinyManifest>>(request).Response;

            var contents = response.MobileWorldContentPaths;
            var suffix = contents.ContainsKey(locale) ? contents[locale] : contents["en"];
            return string.Concat(BaseForManifestUri, suffix);

        }


    }
}
