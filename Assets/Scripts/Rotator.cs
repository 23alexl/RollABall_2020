﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 13, 45) * Time.deltaTime);
    }
}
