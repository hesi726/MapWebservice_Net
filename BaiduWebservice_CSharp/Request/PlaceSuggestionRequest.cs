using BaiduMap.Request.Models;
using BaiduMap.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Request
{
    public class PlaceSuggestionRequest : BaiduRequest<PlaceSuggestionResponse, PlaceSuggestionModel>
    {
        public PlaceSuggestionRequest(PlaceSuggestionModel model) : base(model)
        {
            this.Address = "/place/v2/suggestion";
        }
    }
}
