using TecNM.Practica1.Core.Managers.Interfaces;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Managers;

public class WeightMarsManager : IWeightMarsManager
{
    private readonly IWeightMarsService _service;
    public WeightMarsManager(IWeightMarsService service){
        _service = service;
    }

    public WeightMars GetWeight(Person person){
      return _service.ProcessWeightMars(person);
    }
}