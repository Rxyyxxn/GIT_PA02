﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points_Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            Debug.Log("hit");
            GameManager.Score++;
        }
    }
}
