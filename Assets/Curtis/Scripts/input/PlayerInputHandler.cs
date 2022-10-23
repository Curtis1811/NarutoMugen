using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInputHandler : MonoBehaviour
{
    List<InputAction> playerInputList = new List<InputAction>();

    // Here we are going set some delegates up
    public delegate void delegateJump_Performed(InputAction.CallbackContext ctx);
    public delegateJump_Performed onJumped_Performed;

    public delegate void delegateWalk_Performed(InputAction.CallbackContext ctx);
    public delegateWalk_Performed onWalk_Performed;

    public delegate void delegateWalk_Canceled(InputAction.CallbackContext ctx);
    public delegateWalk_Canceled onWalk_Canceled;
    

    public PlayerInputAction playerInputAction;
    // public StateManager sm;

    public PlayerInput playerInput;

    private void Awake() {
        playerInput = GetComponent<PlayerInput>();
        playerInputAction = new PlayerInputAction();
        playerInputAction.Player.Enable();
        playerInputAction.Player.Jump.performed += Jump_Performed;
        playerInputAction.Player.Walk.performed += Walk_Performed;
        playerInputAction.Player.Walk.canceled += Walk_Canceled;

    }

    private void Update() {
        // Debug.Log(playerInputAction.Player.Walk.ReadValue<Vector2>());
        // onWalk_Performed?.Invoke();
    }

    public void Jump_Performed(InputAction.CallbackContext ctx){
        // Debug.Log("Jump"); //+ ctx);
        onJumped_Performed?.Invoke(ctx);
    }
   
    public void Walk_Performed(InputAction.CallbackContext ctx){
        //Debug.Log("Walking" + ctx.ReadValue<Vector2>());
        onWalk_Performed?.Invoke(ctx);
    } 

    public void Walk_Canceled(InputAction.CallbackContext ctx){
        onWalk_Canceled?.Invoke(ctx);
    }


}
