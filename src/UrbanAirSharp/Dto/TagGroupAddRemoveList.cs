using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanAirSharp.Dto
{
    public class TagGroupAddRemoveList
    {
        [JsonProperty("audience")]
        public Audience Audience {get; set;}

        [JsonProperty("add")]
        public IDictionary<string, IList<string>> AddTags { get; set; }

        [JsonProperty("remove")]
        public IDictionary<string, IList<string>> RemoveTags { get; set; }


        public TagGroupAddRemoveList()
        {
            AddTags = new Dictionary<string, IList<string>>();
            //RemoveTags = new Dictionary<string, IList<string>>();
            //SetTags = new Dictionary<string, IList<string>>();
        }
    }
}
