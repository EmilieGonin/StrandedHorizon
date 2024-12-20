using AYellowpaper.SerializedCollections;
using UnityEngine;
using NaughtyAttributes;

public class Configuration : Singleton<Configuration>
{
    [HorizontalLine(color: EColor.Yellow)]
    [BoxGroup("Economy Settings"), SerializeField] private SerializedDictionary<Resource, int> _startingResources;

    [HorizontalLine(color: EColor.Green)]
    [BoxGroup("Entity Stats"), SerializeField] private float _entityBaseSpeed;

    [Button(enabledMode: EButtonEnableMode.Playmode)]
    public void AddMetal() => AddResource(Resource.METAL);
    [Button(enabledMode: EButtonEnableMode.Playmode)]
    public void AddAmmunition() => AddResource(Resource.AMMUNITION);
    [Button(enabledMode: EButtonEnableMode.Playmode)]
    public void AddMedPlant() => AddResource(Resource.MED_PLANT);

    private void AddResource(Resource resource) => EconomyService.Instance.AddResource(resource, 10);
}