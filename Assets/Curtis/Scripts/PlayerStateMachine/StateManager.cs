using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class StateManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Player player;
    public PlayerInputHandler playerInputHandler;
    public StateMachineFactory smf = new StateMachineFactory();

    public Animator anim;
    public StateStanding stateStanding;
    public StateWalking stateWalking;
    public StateJumping stateJumping;

    #region SuperStates
    public AirState airState;
    public GroundState groundState; 
    #endregion
   


    public BaseState currentState;
    public BaseState previousState;

    public Vector2 Direction;
    public bool canMove;
    
    

    private void Start()  
    {   
        //Here I think we want to instantiate all the of the States
        #region State Instantiating
        stateStanding = smf.standingState(this);
        stateJumping = smf.jumpingState(this);
        stateWalking = smf.walkingState(this);

        airState = smf.airState(this);
        groundState = smf.groundState(this);
        #endregion
    
        currentState = stateStanding;
        currentState.stateEntered();
        
        //This will be changed to tyoe base player later on.
        player = GetComponent<Player>();
        anim = GetComponent<Animator>();
        playerInputHandler = GetComponent<PlayerInputHandler>();

        playerInputHandler.onJumped_Performed += ctxSorter;
        // playerInputHandler.onWalk_Performed += ctxSorter;
        playerInputHandler.onWalk_Performed += setDirection;
        playerInputHandler.onWalk_Canceled += setDirection;
        
        Direction = new Vector2(0,0);
    }

    private void Update() {
        currentState.updateState();
        Debug.Log(currentState);
    }

    public void changeStates(BaseState stateToEnter){
        // Here we want to check if we can change states
        // this.currentState.stateExit();
        this.currentState.changeStates(stateToEnter);
        currentState = stateToEnter;
        
    }

    public void ctxSorter(InputAction.CallbackContext ctx){
        currentState.checkState();
        Debug.Log("ContextSorter");
    }

    public void setDirection(InputAction.CallbackContext ctx){
        if(ctx.phase == InputActionPhase.Performed){
            // Debug.Log("We are performing");
            canMove = true;
            currentState.checkState();
        }else if(ctx.phase == InputActionPhase.Canceled){
            canMove = false;
            currentState.checkState();
        }
    }
}
