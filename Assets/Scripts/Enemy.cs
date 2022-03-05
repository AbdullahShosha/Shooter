using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour,IDamagable
{
    Health Zombie;
    Transform Target;
    NavMeshAgent navMeshAgent;

    //public float TimeBeforeDestroy = 5;
    //float counter = 0;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    private void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").transform;
        Zombie = gameObject.GetComponent<Health>();
        Zombie.health = Zombie.MaxHealth;
        
    }
    void Update()
    {
        navMeshAgent.destination = Target.position;
        
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
