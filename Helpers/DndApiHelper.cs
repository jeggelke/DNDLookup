using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DNDLookup.Helpers
{
    public class DndApiHelper
    {
        public static JObject getStringFromApi(string uri)
        {
            JObject retObject = new JObject();
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("http://dnd5eapi.co/api/");

                //HTTP GET
                var responseTask = client.GetAsync(uri);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var fromApi = result.Content.ReadAsStringAsync().Result;
                    var jo = JObject.Parse(fromApi);
                    retObject = jo;

                }
                else //web api sent error response 
                {
                    //log response status here..

                    //ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return retObject;
        }

        public static List<T> getListFromApi<T>(string uri) where T : new()
        {
            List<T> retList = new List<T>();

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("http://dnd5eapi.co/api/");

                //HTTP GET
                var responseTask = client.GetAsync(uri);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var fromApi = result.Content.ReadAsStringAsync().Result;
                    var jo = JObject.Parse(fromApi);
                    retList = JsonConvert.DeserializeObject<List<T>>(jo["results"].ToString());
                }
                else //web api sent error response 
                {
                    //log response status here..

                    //ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return retList;
        }

        public static T getObjectFromApi<T>(string uri) where T : new()
        {
            T retObject = new T();

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("http://dnd5eapi.co/api/");

                //HTTP GET
                var responseTask = client.GetAsync(uri);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var fromApi = result.Content.ReadAsStringAsync().Result;
                    var jo = JObject.Parse(fromApi);
                    retObject = JsonConvert.DeserializeObject<T>((jo["results"] ?? jo).ToString());
                   
                }
                else //web api sent error response 
                {
                    //log response status here..

                    //ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return retObject;
        }

    }
}
