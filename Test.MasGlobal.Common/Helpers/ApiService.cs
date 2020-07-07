using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Test.MasGlobal.Common.Helpers
{
    public class ApiService
    {
        public static T Get<T>(string SiteBase, string baseAPI, string action)
        {
            T data = default(T);
        
            try
            {

                var client = new RestClient(SiteBase);
                string uri = string.Format("{0}/{1}", baseAPI, action);
                var request = new RestRequest(uri, Method.GET);

                IRestResponse response = client.Execute(request);

                if (response.Content != null)
                {
                    var result = response.Content.ToString();

                    var list = JsonConvert.DeserializeObject<T>(result);
                    return list;

                }

            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            return data;

        }

        public static T Post<T>(string SiteBase, string baseAPI, string action, dynamic model)
        {
            T data = default(T);

            try
            {

                var client = new RestClient(SiteBase);
                string uri = string.Format("{0}/{1}", baseAPI, action);
                var request = new RestRequest(uri, Method.POST);

                if (model != null)
                {
                    request.AddJsonBody(model);
                }

                IRestResponse response = client.Execute(request);

                if (response.Content != null)
                {
                    var result = response.Content.ToString();
                    var list = JsonConvert.DeserializeObject<T>(result);

                    return list;
                }

            }
            catch (System.Exception ex)
            {

                throw ex;
            }

            return data;

        }
    }
}
