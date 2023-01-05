using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class QuoteGenerator
    {
        HttpClient _client = new HttpClient();

        public QuoteGenerator(HttpClient client)
        {
            _client = client;
        }

        #region Ron Swanson

        public string RonSwanson()
        {            
                string ronSwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

                string ronSwansonResponse = _client.GetStringAsync(ronSwansonURL).Result;

                var ronObject = JArray.Parse(ronSwansonResponse);

                return ronObject[0].ToString();
        }

        #endregion

        #region Kanye Rest

        public string Kanye()
        {

            string kanyeRestURL = "https://api.kanye.rest";

            string kanyeRestResponse = _client.GetStringAsync(kanyeRestURL).Result;

            var kanyeObject = JObject.Parse(kanyeRestResponse).GetValue("quote").ToString().Trim();

            return kanyeObject;

        }

        #endregion
    }

}
