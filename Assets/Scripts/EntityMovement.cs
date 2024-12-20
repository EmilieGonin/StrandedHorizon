using UnityEngine;

[RequireComponent(typeof(Entity), typeof(Rigidbody2D))]
public class EntityMovement : MonoBehaviour
{
    private Entity _entity;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _entity = GetComponent<Entity>();
        _rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 movement)
    {
        _rb.linearVelocity = movement * _entity.Speed;
    }
}