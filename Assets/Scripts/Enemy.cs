using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform Player;
    public float TimeBeforeDestroy = 5;
    float counter = 0;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        if(gameObject.GetComponent<BoxCollider>().enabled)
            gameObject.transform.LookAt(Player);
        else
        {
            counter += Time.deltaTime;
            if (counter >= TimeBeforeDestroy)
                Destroy(this.gameObject);
        }
    }
}
