using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class StateJumping : BaseState
{
    StateManager SM;
    public StateJumping(StateManager stateManager) : base(stateManager)
    {
        SM = stateManager;
    }

    public override void stateEntered()
    {   
        Jump();
        _statemanager.player.canJump = false;
        Debug.Log("We are Jumping");
        // throw new System.NotImplementedException();
    }

    public override void stateExit()
    {
        _statemanager.player.canJump = false;
    }

    public override void updateState()
    {
        checkState();
        // Debug.Log("We are in the JumpingState");
        // throw new System.NotImplementedException();   
    }

    public override void checkState(){
        
        if(_statemanager.player.isGrounded){
            Debug.Log("We are swapping to standing");
            changeStates(_statemanager.stateStanding);
        }else if(_statemanager.playerInputHandler.playerInputAction.Player.Jump.triggered){
            Debug.Log("Here we wanna add air movement State");
        }    
    }

    void Jump(){
        // We only really need to be in this state once we press teh button
        // WE wanna Jump then go go to air idel.
        // Debug.Log("We are jumping");
        Debug.Log("JumpHEHEH");
        SM.player.rb.AddForce(new Vector2(0,200));
    }
}