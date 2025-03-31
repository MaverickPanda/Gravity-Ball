using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject Pipe;
    public float SpawnRate = 1.2f;
    public float heightOffset = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        

        StartCoroutine(spawnPipe());
    }

    IEnumerator spawnPipe()
    {
        while (true)
        {
            float lowestPoint = transform.position.y - heightOffset;
            float highestPoint = transform.position.y + heightOffset;

            Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

            

            yield return new WaitForSeconds(SpawnRate);

        }

      
        
    }

    void Update()
    {
        SpawnRate -= 0.02f * Time.deltaTime;
    }
    
}