using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour ,IDamagable
{
    public GameObject GameOverPanel;
    Health player;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponent<Health>();
        player.health = player.MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*private void on(Collision collision)
    {
        if (hit.gameObject.CompareTag("Enemy"))
            Takedamage(100);
        Destroy(hit.gameObject);
    }*/

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Enemy"))
        {
            Takedamage(20);
            Destroy(hit.gameObject);
        }
    }
    public void Takedamage(int amount)
    {
        player.health -= amount;
        if (player.health <= 0)
            Die();
    }
    public void Die()
    {
        Time.timeScale = 0f;
        GameOverPanel.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
}
