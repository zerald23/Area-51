﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObject : MonoBehaviour {

	public void Awake()
	{
		
	}

	public float points;

    public void Collect()
    {
        Debug.Log("Collected " + points + " points!");
        Destroy(gameObject);
    }
}