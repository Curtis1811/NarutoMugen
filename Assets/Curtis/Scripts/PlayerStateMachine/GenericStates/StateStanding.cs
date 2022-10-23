using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class StateStanding : BaseState
{
    public StateStanding(StateManager stateManager) : base(stateManager)
    {}

    // Start is called before the first frame update
    public override void stateEntered()
    {
        // Debug.Log("We are in standingState");
    }

    public override void stateExit()
    {
        // switchState();
        // Debug.Log("We are exiting our statning state and going to enter a new state");   
    }

    public override void updateState()
    {
        //Debug.Log("We are in StandingState");
        // checkState();
    }

    public override void checkState(){
       // InputControl test = _statemanager.playerInputHandler.playerInputAction.Player.Jump.triggered;
       // Debug.Log(_statemanager.playerInputHandler.playerInputAction.Player.Walk.triggered);
        Debug.Log(_statemanager.playerInputHandler.playerInputAction.Player.Jump.triggered);

        if(_statemanager.playerInputHandler.playerInputAction.Player.Jump.triggered){
            Debug.Log("WE are jumpig");
            changeStates(_statemanager.stateJumping);
        } else if(_statemanager.canMove){
            changeStates(_statemanager.stateWalking);
        }
    }

    public override void changeStates(BaseState state){
        
        base.changeStates(state);
        
    }

}
