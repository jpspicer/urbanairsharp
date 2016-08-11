// Copyright (c) 2014-2015 Jeff Gosling (jeffery.gosling@gmail.com)

using UrbanAirSharp.Dto;
using UrbanAirSharp.Request.Base;
using UrbanAirSharp.Response;

namespace UrbanAirSharp.Request
{
    /// <summary>
    /// Used to form a PUSH request
    /// http://docs.urbanairship.com/api/ua.html#tags-named-users
    /// </summary>
    public class NamedUserTagRequest : PostRequest<BaseResponse, TagGroupAddRemoveList>
    {
        public NamedUserTagRequest(TagGroupAddRemoveList TGARList)
            : base(TGARList, "application/json")
        {
            RequestUrl = "api/named_users/tags/";
        }
    }
}
