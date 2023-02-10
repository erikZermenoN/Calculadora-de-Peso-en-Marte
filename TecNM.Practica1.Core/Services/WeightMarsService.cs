using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Services;

public class WeightMarsService:IWeightMarsService
{
    public WeightMars ProcessWeightMars(Person person){
      
      var weightMars = new WeightMars();

      weightMars.Weight = Convert.ToSingle((person.Weight / 9.81) * 3.71);

      return weightMars;

    }
}