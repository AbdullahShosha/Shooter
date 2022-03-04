using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float BulletSpeed = 20f;
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * BulletSpeed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
