using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Car;
    CarController Script;
    void Start()
    {
        OnStart();
    }

    protected virtual void OnStart()
    {
        Script = Car.GetComponent<CarController>();
    }
    // Update is called once per frame
    void Update()
    {
        OnUpdate();  
    }
    protected virtual void OnUpdate()
    {
        float forward = Input.GetAxis("Vertical");
        Debug.Log(Vector3.right * forward * Time.deltaTime);
        transform.Rotate(Vector3.right* forward * Time.deltaTime*Script.Speed*10000);
    }
}
