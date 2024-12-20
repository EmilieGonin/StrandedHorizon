using UnityEngine;

public class Entity : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private float _speed;

    public float Speed => _speed;
}