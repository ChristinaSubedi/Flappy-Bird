using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 3; // How many seconds before pipe spawns
    private float timer = 0; // Counts number of seconds
    public float heightOffset = 10; // Distance of pipes
    public float pipeSpeed = 3f; // Speed at which pipes move to the left

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            spawnPipe();
        }

        // Move existing pipes to the left
        foreach (Transform child in transform)
        {
            child.Translate(Vector3.left * pipeSpeed * Time.deltaTime);
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation, transform);
    }
}
