using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace IDEducation.AuthServer.Models.Formatters
{
    /// <summary>
    /// Reads OAuth Resource Owner request from Message body
    /// </summary>
    public class OAuthROCRequestFormatter : BufferedMediaTypeFormatter
    {
        public OAuthROCRequestFormatter()
        {
            // Add supported content-type(s)
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("application/xml"));
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("application/json"));
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded"));
        }

        public override bool CanReadType(Type type)
        {
            return typeof(OAuthROCRequest).IsAssignableFrom(type);
        }

        public override bool CanWriteType(Type type)
        {
            return false;
        }

        /// <summary>
        /// Reads from HTTP Message
        /// </summary>
        /// <param name="type"></param>
        /// <param name="readStream"></param>
        /// <param name="content"></param>
        /// <param name="formatterLogger"></param>
        /// <returns></returns>
        public override object ReadFromStream(Type type, System.IO.Stream readStream, System.Net.Http.HttpContent content, IFormatterLogger formatterLogger)
        {
            OAuthROCRequest result = null;
            Task<OAuthROCRequest> task = null;

            switch (content.Headers.ContentType.MediaType)
            {
                case "application/x-www-form-urlencoded":
                    task = ReadForm(content);                    
                    break;
                case "application/json":
                    task = ReadJson(content);
                    break;
                case "application/xml":
                    task = ReadXml(content);
                    break;
            }

            if (task != null)
            {
                task.Wait();
                if (task.IsFaulted) throw task.Exception;
                result = task.Result;
            }

            return result;
        }

        /// <summary>
        /// Reads from application/json message
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        private async static Task<OAuthROCRequest> ReadJson(System.Net.Http.HttpContent content)
        {
            var raw = await content.ReadAsStringAsync();
            var serializer = JsonSerializer.Create();
            var dicitionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(raw);

            return FromDictionary(dicitionary);
        }

        /// <summary>
        /// Reads from application/xml message
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        private async static Task<OAuthROCRequest> ReadXml(System.Net.Http.HttpContent content)
        {
            var raw = await content.ReadAsStringAsync();
            var root = XElement.Parse(raw);
            var dictionary = root.Elements()
                                 .ToDictionary(e => e.Name.LocalName, e => e.Value);

            return FromDictionary(dictionary);
        }

        /// <summary>
        /// Reads from application/x-www-form-urlencoded message
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        private async static Task<OAuthROCRequest> ReadForm(System.Net.Http.HttpContent content)
        {
            var raw = await content.ReadAsStringAsync();
            var tokens = raw.Split('&');
            var dictionary = new Dictionary<string, string>();
            foreach (var token in tokens)
            {
                var kp = token.Split('=');
                dictionary[Uri.UnescapeDataString(kp[0])] = Uri.UnescapeDataString(kp[1]);
            }

            return FromDictionary(dictionary);
        }

        /// <summary>
        /// Creats OAuthROCrequest object from given dictionary
        /// </summary>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        private static OAuthROCRequest FromDictionary(Dictionary<string, string> dictionary)
        {
            string grantType, username, password, scope;
            dictionary.TryGetValue("grant_type", out grantType);
            dictionary.TryGetValue("username", out username);
            dictionary.TryGetValue("password", out password);
            dictionary.TryGetValue("scope", out scope);

            return new OAuthROCRequest
            {
                GrantType = grantType,
                Username = username,
                Password = password,
                Scope = scope
            };
        }

       
    }
}