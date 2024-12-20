using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(EntityMovement))]
public class PlayerController : MonoBehaviour
{
    private EntityMovement _movement;
    //private InputSystem_Actions _actions;

    private void Awake()
    {
        _movement = GetComponent<EntityMovement>();
    }

    public void OnMove(InputAction.CallbackContext obj)
    {
        Vector2 movement = obj.ReadValue<Vector2>();
        _movement.Move(movement);
    }
}