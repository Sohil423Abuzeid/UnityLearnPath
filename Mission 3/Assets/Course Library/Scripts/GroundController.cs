using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    private Vector3 startPos;
    public TagsEnums tag = TagsEnums.Ground;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        gameObject.tag= tag.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x-50)
        {
            transform.position = startPos;
        }

    }
}
