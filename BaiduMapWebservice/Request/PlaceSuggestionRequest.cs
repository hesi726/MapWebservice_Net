using BaiduMapWebservice.Request.Models;
using BaiduMapWebservice.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMapWebservice.Request
{
    public class PlaceSuggestionRequest : BaiduRequest<PlaceSuggestionResponse, PlaceSuggestionModel>
    {
        public PlaceSuggestionRequest(PlaceSuggestionModel model) : base(model)
        {
            this.Address = "/place/v2/suggestion";
        }
    }
}
