﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(30, 0, 0);
    private float startDelay = 2;
    private float repeatDelay = 2;
    
    private PlayerController PlayerControllerScript;
    
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnObstacle",startDelay, repeatDelay); 
       PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    
    void SpawnObstacle()
    {
       if(PlayerControllerScript.gameOver == false)
       {
           Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
       }
    }
}
