using System.Collections.Generic;

namespace Lyc.Models.ApisModels.CitySearch
{
    public class structured_formatting
    {
        public string main_text { get; set; }
        public List<matched_substring> main_text_matched_substrings { get; set; }
        public string secondary_text { get; set; }

    }
}