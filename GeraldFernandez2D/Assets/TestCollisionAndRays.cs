﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollisionAndRays : MonoBehaviour {
    float distance = 20f;
    Vector3 source, target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        source = Camera.main.ScreenToWorldPoint (Input.mousePosition);
        target = source + (Vector3.forward) * distance;

        RaycastHit2D hit2D = Physics2D.Raycast (source, target);

        if (hit2D) {
            Debug.Log(hit2D.collider.name);
        } 
	} 

	void OnGUI () {
        GUI.Label(new Rect(0, 0, 100, 50), "This is a Label");
    }

	void OnDrawGizmos () {
        Gizmos.color = Color.green
        Gizmos.DrawRay (source, target);
    }
} 