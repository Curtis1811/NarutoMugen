using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class BaseState
{
    public StateManager _statemanager;
    public InputControl input;
    public BaseState(StateManager sm){
        _statemanager = sm; 
    }
   
    public virtual void checkState(){
        Debug.Log("Base Implementation of CheckedState ");
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    public abstract void stateEntered();
    public abstract void stateExit();
    public abstract void updateState();

    public virtual void changeStates(BaseState stateToSwapTo){
        _statemanager.currentState.stateExit();
        _statemanager.currentState = stateToSwapTo;
        _statemanager.currentState.stateEntered();
    }
    
}
