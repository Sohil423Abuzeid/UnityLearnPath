using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontFanController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back*Time.deltaTime*1000);
    }
}
