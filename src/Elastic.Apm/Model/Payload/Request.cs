﻿using Newtonsoft.Json;

namespace Elastic.Apm.Model.Payload
{
	public class Request
	{
		public string HttpVersion { get; set; }

		public string Method { get; set; }
		public Socket Socket { get; set; }
		public Url Url { get; set; }
	}

	public class Socket
	{
		public bool Encrypted { get; set; }

		[JsonProperty("Remote_address")]
		public string RemoteAddress { get; set; }
	}

	public class Url
	{
		public string Full { get; set; }
		public string HostName { get; set; }
		public string Protocol { get; set; }
		public string Raw { get; set; }
	}
}
