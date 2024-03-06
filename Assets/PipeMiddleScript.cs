using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;//Reference to logic
    // Start is called before the first frame update
    void Start()
    {
        //Added tag to logic to identify
        logic=GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Checks for collision
    private void OnTriggerEnter2D(Collider2D collision){//Are Trigger objects
        if (collision.gameObject.layer==3){//Layer in bird
            logic.addScore(1);
        }
    }


}
