using System;
using System.Collections.Generic;

public enum Resource
{
    METAL,
    AMMUNITION,
    MED_PLANT
}

public class EconomyService : Singleton<EconomyService>
{
    private Dictionary<Resource, int> _resources;

    public int GetResource(Resource resource) => _resources[resource];

    protected override void Awake()
    {
        base.Awake();
        InitResources();
    }

    private void InitResources()
    {
        _resources = new Dictionary<Resource, int>();

        foreach (Resource resource in Enum.GetValues(typeof(Resource)))
        {
            _resources.Add(resource, 0);
        }
    }

    public void AddResource(Resource resource, int value)
    {
        _resources[resource] += value;
    }
}