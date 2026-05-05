using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class global : MonoBehaviour
{
    public int dogsLimits = 1;
    public int dogsAmount = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public bool doIhaveMoreDogs()
    {
        return dogsLimits > dogsAmount;
    }
    public void dogBorn()
    {
        dogsAmount++;
    }
    public void dogDestroy()
    {
        dogsAmount--;
    }
}
