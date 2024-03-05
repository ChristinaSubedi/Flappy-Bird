using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
	
	public float moveSpeed = 10;
	public float deadZone = -50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	//vector3=(-1,0,0), access curr position from transform.position
    	//get left side, add it, use delta time to make move consistent irrespective of frame rate
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x<deadZone)
        {
        	Debug.Log("Pipe Deleted");
        	Destroy(gameObject);
        }
    }
}
