﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteSpin : MonoBehaviour
{
    // Start is called before the first frame upda
    public float speed;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0,0,-1*Time.deltaTime*speed));
    }
}
