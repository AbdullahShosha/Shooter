using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour,IDamagable
{
    Health Zombie;
    Transform Target;
    //public float TimeBeforeDestroy = 5;
    //float counter = 0;
    private void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").transform;
        Zombie = gameObject.GetComponent<Health>();
        Zombie.health = Zombie.MaxHealth;
        
    }
    void Update()
    {
        if(gameObject.GetComponent<BoxCollider>().enabled)
            gameObject.transform.LookAt(Target);
        /*else
        {
            if(!gameObject.GetComponent<DestroyafterSeconds>().enabled)
            gameObject.GetComponent<DestroyafterSeconds>().enabled = true;
            counter += Time.deltaTime;
            if (counter >= TimeBeforeDestroy)
                Destroy(this.gameObject);
        }*/
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
            Takedamage(20);
        
    }


    public void Takedamage(int amount)
    {
        Zombie.health -= amount;
        if (Zombie.health <= 0)
            Die();
    }
    public void Die()
    {
        gameObject.transform.GetComponent<Animator>().SetBool("Dead", true);
        gameObject.transform.GetComponent<BoxCollider>().enabled = false;
        gameObject.GetComponent<DestroyafterSeconds>().enabled = true;
    }
}
