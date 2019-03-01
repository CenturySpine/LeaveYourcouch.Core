using System.Collections.Generic;

namespace Lyc.Models.ApisModels.CitySearch
{
    public class prediction
    {
        public string description { get; set; }
        public string id { get; set; }
        public List<matched_substring> matched_substrings { get; set; }
        public string place_id { get; set; }
        public string reference { get; set; }
        public structured_formatting structured_formatting { get; set; }
        public List<term> terms { get; set; }
        public List<string> types { get; set; }
    }
}