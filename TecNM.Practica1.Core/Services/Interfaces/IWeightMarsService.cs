using TecNM.Practica1.Core.Entities;

namespace TecNM.Practica1.Core.Services.Interfaces;

public interface IWeightMarsService
{
  WeightMars ProcessWeightMars(Person person);
}