using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class Destiny2RestClient
    {
        const string BaseUri = "https://www.bungie.net/Platform/Destiny2/";

        readonly string ApiTokenKey;

        public Destiny2RestClient(string apiTokenKey)
        {
            ApiTokenKey = apiTokenKey;
        }

        public T Execute<T>(RestRequest request) where T:new()
        {
            var client = new RestClient(BaseUri);
            request.AddHeader("X-API-Key", ApiTokenKey);

            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var executeException = new ApplicationException(message, response.ErrorException);
                throw executeException;
            }
            return response.Data;
        }

    }
}
