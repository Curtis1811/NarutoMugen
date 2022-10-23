using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : IGenericState
{
    int health{get; set;}
    float chakra{get; set;} // the game will have 

    Animation anim;

    StateManager stateManager; // here we want a referance to the state manager so we can change the cuirrent state

    public virtual void takeDamage(){
        // ("Here wea re taking damage");
    }

    public virtual void movement(){
        // Debug.Log("Here we are moving");
    }


    void IGenericState.stateEntered()
    {
        // Debug.Log("Here we are entering out state");
        throw new System.NotImplementedException();
    }

    void IGenericState.stateExit()
    {
        // Debug.Log("Here we are EXITING out state");
        throw new System.NotImplementedException();
    }

    void IGenericState.updateState()
    {
        // Debug.Log("Here we are UPDATING out state");
        throw new System.NotImplementedException();
    }

    public void checkState()
    {
        throw new System.NotImplementedException();
    }

    public void switchState()
    {
        throw new System.NotImplementedException();
    }
}
