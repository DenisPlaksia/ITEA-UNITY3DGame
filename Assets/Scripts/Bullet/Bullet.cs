using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody _bulletRigidBody;
    private int _force = 30;

    public Vector3 Direction { private get; set; }
    private void Start()
    {
        _bulletRigidBody = GetComponent<Rigidbody>();
        BulletPush();
    }

    private void BulletPush() => _bulletRigidBody.AddForce(Direction * _force, ForceMode.Impulse);

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<IDamage>() != null)
        {
            collision.gameObject.GetComponent<IDamage>().GetDamage(_force,gameObject.name);
        }
        if(collision.gameObject)
        {
            Destroy(gameObject);
        }
    }
}
