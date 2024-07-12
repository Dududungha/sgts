using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 1;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.position += Vector3.forward * Speed * 0.01f;
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.position += -Vector3.right * Speed * 0.01f;
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.position += -Vector3.forward * Speed * 0.01f;
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.position += Vector3.right * Speed * 0.01f;
        }
    }
}
