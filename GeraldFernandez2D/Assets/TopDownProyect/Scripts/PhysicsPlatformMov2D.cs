using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities2D;

[RequireComponent(typeof(Rigidbody2D))]
public class PhysicsPlatformMov2D : MonoBehaviour {

    public Vector2 speed;
    public List<AxisPair> axes;
    public Rigidbody2D rb2D;
    public float gravity = 8;
    public bool grounded;

    Vector3 movement;


    void Reset() {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.gravityScale = 0;
        rb2D.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement = Vector3.zero;
        for (int i = 0; i < axes.Count; i++)
        {
            if (Input.GetKey(axes[i].keyCode))
            {
                movement += axes[i].direction;
            }
        }
    }

    void FixedUpdate()
    {
        if (!grounded)
        {
            speed.y -= gravity * Time.fixedDeltaTime;
        }

        RaycastHit2D hit2D = Physics2D.Raycast(transform.position, Vector3.down, 0.55f);
        if (hit2D)
        {
            Debug.Log(hit2D.collider.name);
            speed.y = 0;
            grounded = true;
        }
        else
        {
            grounded = false;
        }

        movement = movement.normalized * speed.x * Time.fixedDeltaTime;
        movement.y = speed.y * Time.fixedDeltaTime;
        rb2D.MovePosition(transform.position + movement);
    }

    void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(pointleft, Vector3.down * minDistance);
        Gizmos.DrawRay(pointright, Vector3.down * minDistance)

    }
}
