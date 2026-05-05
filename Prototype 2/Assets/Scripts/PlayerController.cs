using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 20f;
    public GameObject Apple;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveDirction = Input.GetAxis("Horizontal");
        if ((moveDirction > 0&&transform.position.x<=22)|| (moveDirction < 0 && transform.position.x >= -22))
            transform.Translate(Vector3.right*Time.deltaTime*moveSpeed*moveDirction);

        if(Input.GetKeyDown(KeyCode.Space))
            Instantiate(Apple,transform.position,Apple.transform.rotation);

    }
}
