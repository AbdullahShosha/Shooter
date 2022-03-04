using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{

    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime;
    }
}
