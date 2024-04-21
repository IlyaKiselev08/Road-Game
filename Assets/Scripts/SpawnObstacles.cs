using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public float spawnTime, timer;
    public Transform[] sp;
    public GameObject[] obstacles;
    public float diFactor = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            Instantiate(obstacles[Random.Range(0, obstacles.Length)], sp[Random.Range(0, sp.Length)].position, sp[Random.Range(0, sp.Length)].rotation);
            timer = Random.Range(spawnTime - 0.25f * spawnTime, spawnTime + 0.25f * spawnTime);
            
        }
        spawnTime -= 0.001f * diFactor * Time.deltaTime;
    }
}
