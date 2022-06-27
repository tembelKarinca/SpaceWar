using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealth =100;
    public int currentHealth;
    public HealtBar healthBar;
      GameController screen ;
       public GameObject respan;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

       screen = GameObject.FindGameObjectWithTag("Player").GetComponent<GameController>();
    }
    void Update(){
         if (currentHealth <= 0)
        {
            respan.SetActive(true);
        }
    }

   
    public void TakeDamage(int damage){
        currentHealth-=damage;
        healthBar.SetHealth(currentHealth);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "enemyattack1")
        {
            TakeDamage(5);
        }
        if (other.gameObject.tag == "enemybaseattack")
        {
            TakeDamage(1);
        }
    }
}
