using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operation: MonoBehaviour
{
    Vector3 pos;
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            pos.x = +1;
        }
    }
}
 