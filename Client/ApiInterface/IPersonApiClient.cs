﻿using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClient;
using WebApiClient.Attributes;

namespace Client.ApiInterface
{
    public interface IPersonApiClient : IHttpApi
    {
        [HttpGet("/api/persons")]
        ITask<List<Person>> GetPersonsAsync();

        [HttpGet("/api/persons/{id}")]
        ITask<Person> GetPersonAsync(int id);

        [HttpPost("/api/persons")]
        ITask<Person> AddPersonAsync([JsonContent]Person person);

        [HttpPut("/api/persons")]
        ITask<string> EditPersonAsync([JsonContent]int id);

        [HttpDelete("/api/persons/{id}")]
        ITask<string> DeletePersonAsync(int id);

        [HttpGet("/api/persons/tw")]
        ITask<string> RetryTestAsync();
    }
}
