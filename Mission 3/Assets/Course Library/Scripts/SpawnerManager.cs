using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] obstacles;
    private int waitTimeObstacle = 2;
    private float currentTime = 0;
    private float lastObstacleTime = 0;
    private PlayerController playerController;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (!playerController.gameOver&&currentTime >= waitTimeObstacle + lastObstacleTime)
        {
            lastObstacleTime = currentTime;
            waitTimeObstacle = Random.Range(2, 5);
            int obstacle = Random.Range(0, obstacles.Length);
            Instantiate(obstacles[obstacle],gameObject.transform.position,gameObject.transform.rotation);
        }
    }
}
