﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tren : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(speed,0f,0f);
    }
}
