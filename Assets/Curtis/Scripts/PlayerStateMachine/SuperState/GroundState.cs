 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class GroundState : BaseState
{
    public GroundState(StateManager sm) : base(sm)
    {}

    public override void changeStates(BaseState stateToSwapTo)
    {
        PLAYER_STATE playerState = _statemanager.player.getState();
        // I guess we wanna check every frame to see if we are triggering anything 
        switch(playerState){
            case PLAYER_STATE.StateGrounded:
                // Here we wanna run our GoundedState Sorter
                Debug.Log("Grounded State");
                break;
            case PLAYER_STATE.StateAir:
                _statemanager.changeStates(_statemanager.airState);
                Debug.Log("Air State");
                break;
            default:
                Debug.Log("We are staying in this state since there is nothing to change");
                break;
        }
        // base.changeStates(stateToSwapTo);
    }

    public override void checkState()
    {
        if(_statemanager.playerInputHandler.playerInputAction.Player.Jump.triggered){
            changeStates(_statemanager.stateJumping);
        } else if(_statemanager.canMove){
            changeStates(_statemanager.stateWalking);
        }else if(1==1){
            // here we wanna do a check for dashing. If the player presses  Right or left 2 times
        }else if(1==1){
            // Here we wanna do a check for Running. if the player is currently dashing and the buttom to walk has mot been let go
             
        }

        base.checkState();
    }

    public override void stateEntered()
    {
    }

    public override void stateExit()
    {
    }

    public override void updateState()
    {

    }
}
