﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {

    public Transform[] spawnPoints;

    public GameObject blockPrefab;

    public float timeBetweenWaves = 1f;

    private float timeToSpwan = 2f;

    // Use this for initialization
    void Update()
    {
        if (Time.time >= timeToSpwan)
        {
            SpwanBlocks();
            timeToSpwan = Time.time + timeBetweenWaves;
        }

    }

    void SpwanBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }

        }   
    }
}
