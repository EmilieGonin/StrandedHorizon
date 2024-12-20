using TMPro;
using UnityEngine;

public class ResourceDisplayerView : MonoBehaviour
{
    [Header("Data")]
    [SerializeField] private Resource _resource;

    [Header("References")]
    [SerializeField] private TextMeshProUGUI _value;

    private EconomyService _economy;

    private void Awake()
    {
        _economy = EconomyService.Instance;
    }

    private void Update()
    {
        _value.text = _economy.GetResource(_resource).ToString();
    }
}