using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoInstantaneo2D : MonoBehaviour {


    public float speed;
    public float limitRight, limitLeft;

    public List<AxisPair> axes;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        for (int i = 0; i < axes.Count; i++) { 
            if (Input.GetKeyDown(axes[i].keyCode) && !FindObstacle(transform.position + axes
            [i].direction)){ 
                transform.Translate(axes[i].direction);
            }
        }
    }

    bool FindObstacle (Vector3 direction) {
        RaycastHit2D hit2D = Physics2D.Raycast(direction, Vector3.forward);

        if(hit2D.collider.CompareTag("MovableBlock")) {
            hit2D.collider.transform.Translate
    } 
}