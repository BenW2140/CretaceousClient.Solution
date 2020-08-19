using System.Collections.Generic;
using System;
using NewtonSoft.Json;
using NewtonSoft.Json.Linq;

namespace CretaceousClient.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }
    public string Gender { get; set; }

    public static List<Animal> GetAnimals()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Animal> animals = JsonConvert.DeserializeObject<List<Animal>>(jsonResponse.ToString());

      return animals;
    }
  }
}