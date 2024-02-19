using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DemoFakeAPI
{
    public class Service
    {
        string baseUrl = "https://the-one-api.dev/v2/";
        string authToken = "Bearer G4Dkrni57v_Li_VpazY0";


        public RestResponse GETlistofmovies()
        {
            RestClient client = new RestClient(baseUrl);

            RestRequest request = new RestRequest("movie",Method.Get);

            request.AddHeader("Authorization", "Bearer G4Dkrni57v_Li_VpazY0");

            RestResponse response = new RestResponse();

            response =client.Execute(request);

            return response;

        }

        public RestResponse GETspecificmovies()
        {
            RestClient client = new RestClient(baseUrl);

            RestRequest requestmovie = new RestRequest("movie/5cd95395de30eff6ebccde56", Method.Get);

            requestmovie.AddHeader("Authorization", "Bearer G4Dkrni57v_Li_VpazY0");

            RestResponse response = new RestResponse();

            response = client.Execute(requestmovie);

            return response;

        }
        public RestResponse GETHobbitSeries()
        {
            RestClient client = new RestClient(baseUrl);

            RestRequest requestmovie = new RestRequest("movie/5cd95395de30eff6ebccde57", Method.Get);

            requestmovie.AddHeader("Authorization", "Bearer G4Dkrni57v_Li_VpazY0");

            RestResponse response = new RestResponse();

            response = client.Execute(requestmovie);

            return response;

        }

    } 
}
