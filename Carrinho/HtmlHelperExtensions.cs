using System.Web.Mvc;
using Newtonsoft.Json;

namespace Carrinho
{
    public static class HtmlHelperExtensions
    {
        private static readonly JsonSerializerSettings Settings;

        static HtmlHelperExtensions()
        {
            // CamelCase: "MyProperty" will become "myProperty"
            Settings = new JsonSerializerSettings
            {
                ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver(),
                TypeNameHandling = TypeNameHandling.Arrays
            };
        }

        public static MvcHtmlString ToJson(this HtmlHelper html, object value)
        {
            return MvcHtmlString.Create(JsonConvert.SerializeObject(value, Formatting.None, Settings));
        }
    }
}