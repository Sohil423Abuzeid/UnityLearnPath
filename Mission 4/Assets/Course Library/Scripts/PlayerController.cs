using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRig;
    private GameObject focalPoint;
    // Start is called before the first frame update
    void Start()
    {
        playerRig = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("PlatformCenter");
    }

    // Update is called once per frame
    void Update()
    {
        float forward = Input.GetAxis("Vertical");
        playerRig.AddForce(focalPoint.transform.forward*forward*1);
    }
}
