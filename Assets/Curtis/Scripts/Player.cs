using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PLAYER_STATE{
    StateGrounded,
    StateAir,
    StateAttacking,
    StateBlocking,
    StateTakingDamage
}

public class Player : MonoBehaviour
{

    [Range(0.1f,1)]
    public float rayLength;
    // Start is called before the first frame update
    public int speed;
    float health;
    public Rigidbody2D rb;
    PLAYER_STATE playerStates;//{get;set;}

    public bool canJump;
    public bool canMove;
    public bool isGrounded;
    BoxCollider2D collider;
    RaycastHit2D ray;

    void Start()
    {
        playerStates = PLAYER_STATE.StateGrounded;
        speed = 1;
        rb = GetComponent<Rigidbody2D>();
        canJump = false;
        isGrounded = true;
        rayLength = 0.36f;
        collider = this.GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
       grounded();
    }

    void Move(){
        // Here we are going to set up some SUPER basic movement 

    }

  

     void OnDrawGizmosSelected()
    {
        // Draws a 5 unit long red line in front of the object
        Gizmos.color = Color.red;
        Vector3 direction = transform.TransformDirection(Vector3.forward) * 5;
        Gizmos.DrawRay(transform.position, direction);
    }

    public PLAYER_STATE getState(){
        return playerStates;
    }

    void setPlayerState(){
        // here we are going to set the players state based on if they are colliding with the ground or not.
        

    }


// I think down here we want to send a delegate to change our state from grounded to air to whatever action is occuring
    public void grounded(){
        Debug.DrawRay(this.transform.position, new Vector2(0,-rayLength), Color.red);
        int layerMask = 1 << 6;
        if (Physics2D.Raycast(collider.bounds.center, Vector2.down, collider.bounds.extents.y + rayLength, layerMask)){
            isGrounded = true;
        }else{
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log(other.gameObject);
        if(other.gameObject.layer == 6){
            isGrounded = true;
        }else{
            isGrounded = false; 
        }
    }
   
    

}
