using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogController : MonoBehaviour
{
    public global global;
    public float speed=30;
    private void Start()
    {
        GameObject gameObject = GameObject.Find("logicguard");
        global = gameObject.GetComponent<global>();
        global.dogBorn();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void OnDestroy()
    {
        global.dogDestroy();
    }
}
