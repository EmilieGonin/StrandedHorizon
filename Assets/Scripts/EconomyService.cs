using System;
using System.Collections.Generic;
using UnityEngine;

public enum Resource
{
    METAL,
    AMMUNITION,
    MED_PLANT
}

public class EconomyService : MonoBehaviour
{
    public static EconomyService Instance { get; private set; }

    private Dictionary<Resource, int> _resources;

    public int GetResource(Resource resource) => _resources[resource];

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(this);

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
}