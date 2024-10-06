using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using static KeyActions;

[CreateAssetMenu(menuName = "SO/Input")]
public class InputReaderSO : ScriptableObject, IPlayerActions
{
    private KeyActions _keyActions = null;
    
    public UnityAction<Vector2> OnMoveEvent;
    public UnityAction OnJumpEvent; 

    private void OnEnable()
    {
        if (_keyActions == null)
        {
            _keyActions = new KeyActions();
        }
        _keyActions.Player.SetCallbacks(this);
        _keyActions.Enable();
    }

    void IPlayerActions.OnMove(InputAction.CallbackContext context)
    {
        OnMoveEvent?.Invoke(context.ReadValue<Vector2>());
    }

    void IPlayerActions.OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            OnJumpEvent?.Invoke();
        }
    }
}
