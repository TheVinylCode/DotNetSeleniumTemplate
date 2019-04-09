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