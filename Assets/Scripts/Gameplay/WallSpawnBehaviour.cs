using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawnBehaviour : MonoBehaviour
{
    //Time between pipe spawns
    public float TimeInterval;
    public bool GameOver = false;
    //Pipe Reference
    public GameObject WallRef;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWalls());
    }

    public IEnumerator SpawnWalls()
    {
        float randY = 0;

        while (!GameOver)
        {
            Vector3 spawnPosition = new Vector3(transform.position.x, WallRef.transform.localScale.y/2, transform.position.z);

            //Spawn in an instance of the pipe prefab at the given position with a default rotation
            GameObject pipe = Instantiate(WallRef.gameObject, spawnPosition, new Quaternion());
            //Get the movement component attatched to the spawned opject
            MovementBehaviour moveScript = pipe.GetComponent<MovementBehaviour>();
            //Set the starting cosine to be a random value
            moveScript.StartCos = Random.Range(-1, 1);

            //Wait for the given time interval before resuming the function
            yield return new WaitForSeconds(TimeInterval);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
