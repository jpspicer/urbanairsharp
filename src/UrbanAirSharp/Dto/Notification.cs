﻿// Copyright (c) 2014-2015 Jeff Gosling (jeffery.gosling@gmail.com)
using System;
using Newtonsoft.Json;

namespace UrbanAirSharp.Dto
{
	public class Notification
	{
		[JsonProperty("alert")]
		public string DefaultAlert { get; set; }

		[JsonProperty("android")]
		public AndroidAlert AndroidAlert { get; set; }

		[JsonProperty("ios")]
		public IosAlert IosAlert { get; set; }

		[JsonProperty("wns")]
		public WindowsAlert WindowsAlert { get; set; }

		[JsonProperty("mpns")]
		public WindowsPhoneAlert WindowsPhoneAlert { get; set; }

		[JsonProperty("blackberry")]
		public BlackberryAlert BlackberryAlert { get; set; }

        [JsonProperty("actions")]
        public Actions Actions { get; set; }
	}
}
