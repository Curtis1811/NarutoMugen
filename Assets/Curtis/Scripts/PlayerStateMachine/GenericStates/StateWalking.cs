using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class StateWalking : BaseState
{

    public StateWalking(StateManager stateManager) : base(stateManager)
    {}

    public override void stateEntered()
    {
    }

    public override void stateExit()
    {
        // Debug.Log("We are Entering the Exit state");
        // Debug.Log("Exit");
    }

    public override void updateState()
    {
        movement(_statemanager.Direction);
        checkState();
        // Debug.Log("We are Entering the Update state");
     
    }

    public override void checkState()
    {
        // Debug.Log(_statemanager.canMove);
        //Here we wanna check to see if our variable is still on. If it is then we are going to change our state to something
        if(!_statemanager.canMove){
            changeStates(_statemanager.stateStanding);
        }
        //base.checkState();
    }

    public void movement(Vector2 Direction){
        // Debug.Log("We are moving here " + Direction);
        if(Input.GetKey(KeyCode.D)){
            _statemanager.player.transform.position += new Vector3(_statemanager.player.speed * Time.deltaTime,0,0);
        }else if(Input.GetKey(KeyCode.A)){
            _statemanager.player.transform.position -= new Vector3(_statemanager.player.speed * Time.deltaTime,0,0);
        }
    }


}
