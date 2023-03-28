using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Dapper;
using Pizzas.API.Models;

namespace Pizzas.API.Utils; 
public static class HTTPHelper
{
    public static async Task<string> GetContentAsync (string targetURL, string defaultValueOnError)
    {
        string  returnValue;
        HttpClient httpClient;
        returnValue=defaultValueOnError;
        httpClient=new HttpClient();
        try {
            using(HttpResponseMessage response=await httpClient.GetAsync(targetURL))
            {
                returnValue=await response.Content.ReadAsStringAsync();     
        }
    }catch(Exception ex)
    {
        returnValue=defaultValueOnError;
    }

    return returnValue;
    }
}