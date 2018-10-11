using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuosPhysics2D : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 movement = Vector3.zero;
        for (int i = 0; i < axes.Count; i++)
        {
            if (Input.GetKey(axes[i].keyCode) && !FindObstacle(axes[i].direction))
            {
                movement += axes[i].direction;
     
	}
}
