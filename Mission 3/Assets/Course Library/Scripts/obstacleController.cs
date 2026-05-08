using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleController : MonoBehaviour
{
    public float speed = 30.0f;
    public TagsEnums tag = TagsEnums.Obstacle;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag= tag.ToString();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!playerController.gameOver)    
            transform.Translate(Vector3.left*Time.deltaTime*speed);

        if(transform.position.y < -2 )
            Destroy(gameObject);
    }
}
