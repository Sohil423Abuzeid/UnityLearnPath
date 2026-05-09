using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody Rigidbody;
    private GameObject player;
    public Tags tag = Tags.Enemy;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        gameObject.tag = tag.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody.AddForce((player.transform.position-transform.position).normalized);
    }
}
