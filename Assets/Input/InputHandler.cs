using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "Input Handler", menuName = "Input Handler")]
public class InputHandler : ScriptableObject, CustomInput.IGameplayActions {
    private CustomInput input;

    public UnityAction<Vector2> actionOnMove;
    public UnityAction actionShowMenu;


    public void enableMenu() {
        input.Gameplay.Disable();
        input.Menu.Enable();
    }

    public void enableGameplay() {
        input.Gameplay.Enable();
        input.Menu.Disable();
    }

    private void OnEnable() {
        if (input == null) {
            input = new CustomInput();
        }
        input.Gameplay.SetCallbacks(this);

        enableMenu();
    }

    private void OnDisable() {
        input.Gameplay.Disable();
    }

    public void OnMove(InputAction.CallbackContext context) {
        if (context.phase == InputActionPhase.Performed || context.phase == InputActionPhase.Canceled) {
            actionOnMove?.Invoke(context.ReadValue<Vector2>());
        }
    }

    public void OnShowMenu(InputAction.CallbackContext context) {
        if (context.phase == InputActionPhase.Performed) {
            actionShowMenu?.Invoke();
        }
    }
}
