using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "My Input Handler", menuName = "My Input Handler")]
public class MyInputHandler : ScriptableObject, MyCustomInput.IGameplayActions
{
    private MyCustomInput input;
    public UnityAction<Vector3> OnSetDirectionAction;
    public UnityAction OnPauseAction;

    private void OnEnable()
    {
        if (input == null)
        {
            input = new MyCustomInput();
        }

        input.Gameplay.SetCallbacks(this);
        input.Gameplay.Enable();

    }

    private void OnDisable()
    {
        input.Gameplay.Disable();
    }

    public void OnSetDirection(InputAction.CallbackContext context)
    {
        // throw new System.NotImplementedException();

        Debug.Log("Set Direction : " + context.ReadValue<Vector2>() + context.phase);


        if (context.phase == InputActionPhase.Performed || context.phase == InputActionPhase.Canceled)
        {
            OnSetDirectionAction?.Invoke(context.ReadValue<Vector2>());
        }

    }
    
    public void OnPause(InputAction.CallbackContext context) 
    {
        if (context.phase == InputActionPhase.Performed) 
        {
            OnPauseAction?.Invoke();
        }
    }
}
