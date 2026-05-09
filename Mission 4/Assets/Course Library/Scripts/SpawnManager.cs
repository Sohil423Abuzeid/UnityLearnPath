using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Objects;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        int index = UnityEngine.Random.Range(0,Objects.Length);
        Vector3 spawnPoint = SpawnPoint();
        Instantiate(Objects[index], spawnPoint,transform.rotation);
    }
    Vector3 SpawnPoint()
    {
        float x = UnityEngine.Random.Range(0.0f,7f);
        float z =UnityEngine.Random.Range(0.0f,7f);
        return new Vector3(x,transform.position.y,z);
    }
}
