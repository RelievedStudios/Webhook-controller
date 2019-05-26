using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace web_hook_controll
{
    class send_web_hook
    {
        public static string sendWebHook(string webAddr, string Message)
        {
            try
            {

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    dynamic json = new JObject();
                    json.content = Message;
                    //string json = "{ \"content\" : \"" + Message + "\" }";

                    streamWriter.Write(json);
                    streamWriter.Flush();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    Console.WriteLine(responseText);

                    //Now you have your response.
                    //or false depending on information in the response     
                }
                String StatusVar = "Message sent: " + Message;
                return StatusVar;
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
                var StatusVar = ex.Message;
                return StatusVar;
            }
        }
        public static string sendEmbedWebHook(string webAddr, string Message)
        {
            try
            {

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {

                    string json = Message;

                    streamWriter.Write(json);
                    streamWriter.Flush();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    Console.WriteLine(responseText);

                    //Now you have your response.
                    //or false depending on information in the response     
                }
                String StatusVar = "Message sent: " + Message;
                return StatusVar;
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
                var StatusVar = ex.Message;
                return StatusVar;
            }
        }
        public static string sendImageWebHook(string webAddr, string ImageUrl, string Title)
        {
            try
            {

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {

                    JObject image =
                        new JObject(
                            new JProperty("embeds",
                            new JArray(
                                new JObject(
                                new JProperty("title", Title),
                                new JProperty("image",
                                        new JObject(
                                            new JProperty("url", ImageUrl)))))));
                    //string json = "{ \"embeds\" : [{ \"title\" : \"" + Title + "\", \"image\" : { \"url\" : \"" + ImageUrl + "\" } }] }";
                    var output = image.ToString();
                    streamWriter.Write(output);
                    streamWriter.Flush();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    Console.WriteLine(responseText);

                    //Now you have your response.
                    //or false depending on information in the response     
                }
                String StatusVar = "Image sent image with title: " + Title;
                return StatusVar;
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
                var StatusVar = ex.Message;
                return StatusVar;
            }
        }
    }
}
