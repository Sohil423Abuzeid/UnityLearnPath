using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    public Tags tag = Tags.PowerUp;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag= tag.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up*20*Time.deltaTime);
    }
}
