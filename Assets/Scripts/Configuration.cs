using AYellowpaper.SerializedCollections;
using UnityEngine;

public class Configuration : MonoBehaviour
{
    [SerializeField] private SerializedDictionary<Resource, int> _startingResources;
}