//note: justin
// There seems to be a bug in the api that causes an error if charset is added to the contenttype when posting to the named_user endpoint. I implemented the media overrite as a temporary hack around that.
//It also, to some extent, fuffils the Todo of the original auther to abstract the content type.

// Copyright (c) 2014-2015 Jeff Gosling (jeffery.gosling@gmail.com)

using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UrbanAirSharp.Response;

namespace UrbanAirSharp.Request.Base
{
    /// <summary>
    /// Used to form a VALIDATE request
    /// Accept the same range of payloads as /api/push, but parse and validate only, without sending any pushes
    /// 
    /// http://docs.urbanairship.com/reference/api/v3/push.html
    /// </summary>
    public class PostRequest<TResponse, TContent> : BaseRequest<TResponse> where TResponse : BaseResponse, new()
    {
        //TODO: PostRequest shouldn't declate this - should be more abstract
        public readonly Encoding Encoding = Encoding.UTF8;
        public const string MediaType = "application/json";
        private string _mediaOverrite;

        protected TContent Content;

        public PostRequest(TContent content, string MediaType = null)
            : base(ServiceModelConfig.Host, ServiceModelConfig.HttpClient, ServiceModelConfig.SerializerSettings)
        {
            RequestMethod = HttpMethod.Post;
            Content = content;
            _mediaOverrite = MediaType;
        }

        public override async Task<TResponse> ExecuteAsync()
		{
			Log.Debug(RequestMethod + " - " + Host + RequestUrl);

			var json = JsonConvert.SerializeObject(Content, SerializerSettings);

			Log.Debug("Payload - " + json);

            StringContent content;
            if (!String.IsNullOrEmpty(_mediaOverrite))
            {
                content = new StringContent(json, Encoding, _mediaOverrite);
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(_mediaOverrite);
            }
            else
            {
                content = new StringContent(json, Encoding, MediaType);
            }

			var response = await HttpClient.PostAsync(Host + RequestUrl, content);

			return await DeserializeResponseAsync(response);
		}
    }
}
