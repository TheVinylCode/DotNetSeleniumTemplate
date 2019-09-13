using System.Collections.Generic;

namespace DotnetSeleniumTemplate.Data
{
    /// <summary>
    /// This class contains Dictionaries that holds Tkey and 
    /// a TValue, where the TValue is the ID, XPath, Css, 
    /// etc of an element. 
    /// </summary>
    public class WebElementIdsXPaths
    {
        //this Dictionary is used for the GoogleSearch test. 
        public static Dictionary<string, string> GoogleElements =
            new Dictionary<string, string>
            {
                { "GoogleSearchBar", "//*[@id=\"tsf\"]/div[2]/div[1]/div[1]/div/div[2]/input" },
                { "GoogleSearchButton", "//*[@id=\"tsf\"]/div[2]/div[1]/div[3]/center/input[1]" },
                { "GoogleLogo", "//*[@id=\"logo\"]/img" }
            };
        
        public static Dictionary<string, string> DictionaryName = 
            new Dictionary<string, string>
        {
            { "Key1", "Value1" },
            { "Key2", "Value2" },
            { "Key3", "Value3" },
            { "Key4", "Value4" }
        };
    }
}