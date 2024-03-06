using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
	//Reference the body of bird
	public Rigidbody2D myRigidbody;
	public float flapStrength;	
    public LogicScript logic;
    public bool birdIsAlive= true;
    //if goes beneath the screen dead
    public float minYPosition = -16.5f;

    
    // Start is called before the first frame update
    void Start()
    {
        //Code as soon as it starts
        gameObject.name = "Bob";
        //access the logic script
        logic=GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

        
    }

    // Update is called once per frame
    void Update()
    {
        //Fires every line of code over and over in each frame
        //Checks if space bar is clicked
        if  (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
        //Vector2.up sets velocity to (0,1) so only in y dir
        	myRigidbody.velocity = Vector2.up * flapStrength ; 
	}    

            // Check if the bird goes below the minimum Y position
        if (transform.position.y < minYPosition && birdIsAlive)
        {
            // Trigger game over
            logic.gameOver();
            birdIsAlive = false;
        }

       
    }

    public void OnCollisionEnter2D(Collision2D collision){//Not trigger objects
        logic.gameOver();
        birdIsAlive=false;
    }
}
