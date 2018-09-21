﻿using InstagramApiSharp.Classes.ResponseWrappers.BaseResponse;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers
{
    public class InstaExploreFeedResponse : BaseLoadableResponse
    {
        [JsonIgnore] public InstaExploreItemsResponse Items { get; set; } = new InstaExploreItemsResponse();
    }
}