using NUnit.Framework;
using RestSharp;
using System.Net;

namespace DemoFakeAPI
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetListofMovies()
        {
            Service service = new Service();
            RestResponse response = service.GETlistofmovies();
            Assert.IsNotNull(response);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void GetSpecificMovie()
        {
            Service service = new Service();
            RestResponse response = service.GETspecificmovies();
            Assert.IsNotNull(response);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void GetHobbitSeries()
        {
            Service service = new Service();
            RestResponse response = service.GETHobbitSeries();
            Assert.IsNotNull(response);
            Assert.IsNotNull(response);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
