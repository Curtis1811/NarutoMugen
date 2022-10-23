using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirState : BaseState
{
    // Start is called before the first frame update
    public AirState(StateManager sm) : base(sm)
    {}

    public override void changeStates(BaseState stateToSwapTo)
    {
        PLAYER_STATE playerState = _statemanager.player.getState();

        switch(playerState){
            case PLAYER_STATE.StateGrounded:
                Debug.Log("Grounded State");
                
                break;
            case PLAYER_STATE.StateAir:
                Debug.Log("Here we are entering the ");
                break;
            default:
                Debug.Log("We are staying in this state since there is nothing to change");
                break;
        }

        base.changeStates(stateToSwapTo);
    }

    public override void checkState()
    {
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
