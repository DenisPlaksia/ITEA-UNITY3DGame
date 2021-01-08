using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    private int force = 30;

    public Vector3 Direction { private get; set; }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        BulletPush();
    }

    private void BulletPush() => rb.AddForce(Direction * force, ForceMode.Impulse);

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<IDamage>() != null)
        {
            collision.gameObject.GetComponent<IDamage>().GetDamage(force);
        }
        if(collision.gameObject)
        {
            Destroy(gameObject);
        }
    }
}
