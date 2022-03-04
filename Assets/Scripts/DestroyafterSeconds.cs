using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyafterSeconds : MonoBehaviour
{
    public float TimeBeforeDestroy  = 5;
    float counter = 0;
    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= TimeBeforeDestroy)
            Destroy(this.gameObject);
    }
    
    
}
