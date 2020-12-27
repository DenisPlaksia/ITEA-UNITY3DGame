using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    private float force = 20f;

    public Vector3 Direction { private get; set; }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        BulletPush();
    }

    private void BulletPush() => rb.AddForce(Direction * force, ForceMode.Impulse);
}
