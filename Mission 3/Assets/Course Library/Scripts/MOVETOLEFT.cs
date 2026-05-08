using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVETOLEFT : MonoBehaviour
{
    public float speed = 30.0f;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerController.gameOver)
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
