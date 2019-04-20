using Akshayblevel.FluentValidation.ApiModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Akshayblevel.FluentValidation.Controllers
{
    [Route("Employee")]
    public class EmployeeController : Controller
    {
        // GET Employee
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Akshay", "Panth" };
        }

        // GET Employee/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST Employee
        [HttpPost]
        public string Post([FromBody]Employee emp)
        {
            return "Employee created successfully!";
        }

        // PUT Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE Employee/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}