namespace restAssuredNet_boilerplate
{
using RestAssured.Request.Builders;
using RestAssured.Request.Logging;
using model;
using RestAssured.Response.Logging;

namespace RestAssuredTests
{
    using NUnit.Framework;
    using static RestAssured.Dsl;

    public class ExampleGetTests
    {
        [Test]
        public void GetUser_CheckStatusCode_ShouldBe200()
        {
        Given()
            .When()
            .Get("https://jsonplaceholder.typicode.com/users/1")
            .Then()
            .StatusCode(200);
        }

        [Test]
        public void GetUser_LogAllResponseDetails()
        {
        Given()
            .When()
            .Get("https://jsonplaceholder.typicode.com/users/1")
            .Then()
            .Log(ResponseLogLevel.All);
        }

        [Test]
        public void BodyReturn_CheckStreet_ShouldBeKulasLight()
        {
        Given()
            .When()
            .Get("https://jsonplaceholder.typicode.com/users/1")
            .Then()
            .Body("address.['street']", NHamcrest.Is.EqualTo("Kulas Light"))
            .Log(ResponseLogLevel.Body);
        }
    }

    public class Deserialization
    {
        [Test]
        public void PostNew_CheckStatusCode_ShouldBe201()
        {
            Post myNewPost = new Post()
            {
                UserId = 1,
                Title = "Nullam et maximus",
                Body = "Nam fermentum blandit aliquet. Vestibulum"
            };

            Given()
            .Log(RequestLogLevel.All)
            .Body(myNewPost)
            .When()
            .Post("http://jsonplaceholder.typicode.com/posts")
            .Then()
            .StatusCode(201);
        }
    }
}
}