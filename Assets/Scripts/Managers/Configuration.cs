using AYellowpaper.SerializedCollections;
using UnityEngine;
using NaughtyAttributes;

public class Configuration : Singleton<Configuration>
{
    [SerializeField] private SerializedDictionary<Resource, int> _startingResources;

    [Button(enabledMode: EButtonEnableMode.Playmode)]
    public void AddMetal() => AddResource(Resource.METAL);
    [Button(enabledMode: EButtonEnableMode.Playmode)]
    public void AddAmmunition() => AddResource(Resource.AMMUNITION);
    [Button(enabledMode: EButtonEnableMode.Playmode)]
    public void AddMedPlant() => AddResource(Resource.MED_PLANT);

    private void AddResource(Resource resource) => EconomyService.Instance.AddResource(resource, 10);
}