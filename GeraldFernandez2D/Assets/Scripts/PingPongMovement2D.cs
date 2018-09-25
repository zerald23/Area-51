using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongMovement2D : EntityMovement2D {

    public float distance;
    private float currentDistance;

	// Use this for initialization
	void Start () {
		
	}

    protected override void Update () {
	

	// Logica PingPong
        currentDistance *= movement.magnitude;
        if (currentDistance >= distance)
        {
            
        }
	}
}
