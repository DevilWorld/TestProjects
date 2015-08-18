using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJS3.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AngularJS3.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult GetPersonDetails()
        {
            PersonRepository _repository = new PersonRepository();

            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(_repository.GetPersons(), settings),
                ContentType = "application/json"
            };
            return jsonResult;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}