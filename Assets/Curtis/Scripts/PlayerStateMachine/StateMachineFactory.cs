using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineFactory
{
    /*  The state machine Factory should pretty much be returning the instantiate states
        These should be in functions since we are going to be call them from
        from stateManager to create these states. 
    */

    #region GenericStates

    public StateStanding standingState(StateManager stateManager){
        return new StateStanding(stateManager);
    }
    
    public StateWalking walkingState(StateManager stateManager){
        return new StateWalking(stateManager);
    }

    public StateJumping jumpingState(StateManager stateManager){
        return new StateJumping(stateManager);
    } 
    
    #endregion


// __________________________________________________________________________


    #region Super States
    
    public AirState airState(StateManager stateManager){
        return new AirState(stateManager);
    }

    public GroundState groundState(StateManager stateManager){
        return new GroundState(stateManager);
    }

    #endregion




}
