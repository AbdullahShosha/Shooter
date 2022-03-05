using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    float SecondsBeforeSpawn = 6 ,counter = 6;
    public GameObject Enemy;
    void Update()
    {
        if (counter >= SecondsBeforeSpawn)
        { 
            // didn't instaniate them in random places because i don't want to handle multiple enemy spawned at the same pos (^_^)
            Instantiate(Enemy,gameObject.transform);
            counter = 0;
        }
        counter += Time.deltaTime;
    }
}
