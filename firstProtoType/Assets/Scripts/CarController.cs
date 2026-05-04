using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class CarController : MonoBehaviour
{
    public float Speed = 20.0f;
    public float TurnSpeed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float forward = Input.GetAxis("Vertical");
        float ReverseTurn = forward >= 0 ? 1 : -1;
        float turn = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * Speed*forward);
        transform.Rotate(Vector3.up * Time.deltaTime * turn*TurnSpeed* ReverseTurn);
    }
}
