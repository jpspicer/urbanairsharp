﻿// Copyright (c) 2014-2015 Jeff Gosling (jeffery.gosling@gmail.com)
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace UrbanAirSharp.Dto
{
	/// <summary>
	/// http://docs.urbanairship.com/reference/api/v3/actions.html
	/// </summary>
	public class Actions
	{
		[JsonProperty("open")]
		public OpenAction OpenAction { get; set; }

        [JsonProperty("share")]
        public string ShareAction { get; set; }

		[JsonProperty("add_tag")]
		public IList<string> AddTags { get; set; }

		[JsonProperty("remove_tag")]
		public IList<string> RemoveTags { get; set; }

        //todo: implement app_defined
        //[JsonProperty("app_defined")]
	}
}
