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
        public IDictionary<string, IList<string>> Add { get; set; }

        [JsonProperty("remove")]
        public IDictionary<string, IList<string>> Remove { get; set; }

        [JsonProperty("set")]
        public IDictionary<string, IList<string>> Set { get; set; }

        public TagGroupAddRemoveList()
        {
            Add = new Dictionary<string, IList<string>>();
            Remove = new Dictionary<string, IList<string>>();
            Set = new Dictionary<string, IList<string>>();
        }

        //Only One can be sent at a time. this prevents empty ones being sent and causing an error
        public bool ShouldSerializeAdd()
        {
            return Add.Any();
        }

        public bool ShouldSerializeRemove()
        {
            return Remove.Any();
        }

        public bool ShouldSerializeSet()
        {
            return Set.Any();
        }
    }
}
