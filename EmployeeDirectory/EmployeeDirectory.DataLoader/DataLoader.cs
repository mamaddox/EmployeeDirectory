using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using EmployeeDirectory.Entities;
using EmployeeDirectory.Entities.Attributes;
using Newtonsoft.Json;

namespace EmployeeDirectory.Data
{
    public static class DataLoader
    {
        //This api returns an array or 50 people
        private const string employeesUrl = "https://my.api.mockaroo.com/users.json?key=13b96c70";

        public static IEnumerable<EmployeeEntity> GetEmployees()
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(employeesUrl)
            };
            var employeeEntities = new List<EmployeeEntity>();

            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );

            var response = httpClient.GetAsync("").Result;

            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync().Result;
                 employeeEntities = JsonConvert.DeserializeObject<List<EmployeeEntity>>(jsonString);
            }
            else
            {
                throw new HttpResponseException(new HttpResponseMessage(response.StatusCode));
            }

            httpClient.Dispose();
            return employeeEntities.AsEnumerable();
        }
    }
}