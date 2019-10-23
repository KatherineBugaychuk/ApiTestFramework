﻿using ApiTestFramework.Endpoints.Requests;
using ApiTestFramework.Endpoints.Responses;
using ApiTestFramework.Validation;
using Newtonsoft.Json;

namespace ApiTestFramework.Tests
{
    class CommonForWeatherTests : EndpointsContainer
    {
        public void SendRequestCheckResponse(Request request, CommonResponse expectedResponse, RequestType requestType = RequestType.Get)
        {
            Response response = WeatherEndpoint.SendGetRequest(request).Execute().GetResponse(0);
            CommonResponse actualResponse = JsonConvert.DeserializeObject<CommonResponse>(response.ResponseBody);
            Comparator.CompareObjects(actualResponse, expectedResponse);
        }
    }
}