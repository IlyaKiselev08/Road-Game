using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawn : MonoBehaviour
{
    public float distance, minDistance, maxDistance;
    public Transform player;
    public GameObject road;
    public Transform sp;
    public bool isSpawn;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; 
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, player.position);
        if(distance < minDistance && isSpawn == false)
        {
            Instantiate(road, sp.position,sp.rotation);
            isSpawn = true;
        }
        if(distance > maxDistance && isSpawn == true)
        {
            Destroy(gameObject);
        }
    }
}
