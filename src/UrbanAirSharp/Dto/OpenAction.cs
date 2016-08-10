// Copyright (c) 2014-2015 Jeff Gosling (jeffery.gosling@gmail.com)
using System;
using Newtonsoft.Json;

namespace UrbanAirSharp.Dto
{
    public enum OpenActionType {url,deep,landing};
	public class OpenAction
	{
		//either url, deep_link or landing_page
		//TODO: landing_page not supported yet
		[JsonProperty("type")]
		public string Type { get; set; }

		//TODO: landing_page content not supported yet
		//http://docs.urbanairship.com/reference/api/v3/actions.html#open
		[JsonProperty("content")]
		public string Content { get; set; }

        public OpenAction(OpenActionType type, string content)
        {
            switch (type)
            {
                case OpenActionType.url:
                    this.Type = "url";
                    break;
                case OpenActionType.deep:
                    this.Type = "deep_link";
                    break;
                case OpenActionType.landing:
                    this.Type = "landing_page";
                    break;
            }

            this.Content = content;
        }
	}
}
