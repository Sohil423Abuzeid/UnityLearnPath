using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Animals;
    private System.Random rand;
    private float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        rand = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>=2.5f)
        { 
            timer = 0;
            int animalIndex = rand.Next(0, Animals.Length-1);
            Vector3 animalPostion = new Vector3(transform.position.x+rand.Next(0,44), transform.position.y, transform.position.z);
            Instantiate(Animals[animalIndex], animalPostion, Animals[animalIndex].transform.rotation);
        }
    }
    
}
