using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    private GameObject prevPipe;
    private float startingPosX = 24;
    public float differenceToSpawn;
    public float spawnRate;
    public float heighOffset;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        float diff = startingPosX - prevPipe.transform.position.x;
        Debug.Log(diff > differenceToSpawn);
        if (diff > differenceToSpawn)
        {
            spawnPipe();
        }

    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heighOffset;
        float highestPoint = transform.position.y + heighOffset;

        prevPipe = Instantiate(pipe, new Vector3(transform.position.x, UnityEngine.Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        // startingPosX = prevPipe.transform.position.x;
    }
}
