using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class FrontWheelController : WheelController
{
    public GameObject MyIdel;
    // Start is called before the first frame update
    void Start()
    {
        OnStart();
    }
    protected override void OnStart()
    {
        base.OnStart();
    }
    // Update is called once per frame
    void Update()
    {
        OnUpdate();
    }
    protected override void OnUpdate()
    {
        base.OnUpdate();
        float turn = Input.GetAxis("Horizontal");
        if (turn != 0 && Math.Abs(Mathf.DeltaAngle(transform.eulerAngles.y, Car.transform.eulerAngles.y)) < 40)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turn * 50);
        }
        else if (turn == 0 && Math.Abs(Mathf.DeltaAngle(transform.eulerAngles.y, Car.transform.eulerAngles.y)) !=0)
            transform.LookAt(MyIdel.transform.position);
                //   transform.Rotate(Vector3.up* (Mathf.DeltaAngle(transform.eulerAngles.y, Car.transform.eulerAngles.y)));
        //Debug.Log(Car.transform.rotation.y - transform.rotation.y);
        //transform.rotation = Car.transform.rotation;
    }
    void LateUpdate()
    {
        
    }
}
