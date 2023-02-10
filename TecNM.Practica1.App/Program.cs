// See https://aka.ms/new-console-template for more information
using System;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Managers;
using TecNM.Practica1.Core.Services;

namespace TecNM.Practica1.App;

public static class Program {
    public static void Main(string[] args){
      float weight = 0;

      System.Console.WriteLine("Please enter the Weight");
      Single.TryParse(System.Console.ReadLine(), out weight);

      var weightMars = new WeightMars();
      var person = new Person{Weight = weight};

      var service = new WeightMarsService();
      var manager = new WeightMarsManager(service);

      weightMars = manager.GetWeight(person);

      System.Console.WriteLine($"Your weight on Mars is: {weightMars.Weight}");
    }
}
