using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    int speed;
    

    void Start()
    {
        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move(){
        // Here we are going to set up some SUPER basic movement 

        if(Input.GetKey(KeyCode.D)){
            this.transform.position += new Vector3(speed * Time.deltaTime,0,0);
        }else if(Input.GetKey(KeyCode.A)){
           this.transform.position -= new Vector3(speed * Time.deltaTime,0,0);
        }
    }


    
}
