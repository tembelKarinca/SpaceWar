using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mobilEnemyControl : MonoBehaviour
{
     GameObject Char;

    RaycastHit2D ray;
    GameController screen ;
    public GameObject respan;
    public GameObject EnemyHealthBar;

   public LayerMask layermask;
   public GameObject Bullet;
   float fireTime= 0;
   public int maxHealth =100;
    public int currentHealth;
    public HealtBar healthBar;

    void Start()
    {
        Char = GameObject.FindGameObjectWithTag("Player");
               currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        screen = GameObject.FindGameObjectWithTag("screen").GetComponent<GameController>();
    }

    private void FixedUpdate()
    {
        if (currentHealth <= 0)
        {
            screen.AddScore (50);
           gameObject.SetActive(false);
           EnemyHealthBar.SetActive(false);
           currentHealth = maxHealth;

           

        }
        
        DidItSeePlayer();

        if (ray.collider.tag =="Player")
        {
          Fire();
        }
        else
        {
          
        }
    }

    void DidItSeePlayer()
    {
        Vector3 rayMyDirection = Char.transform.position - transform.position;
        ray = Physics2D.Raycast(transform.position, rayMyDirection, 1000,layermask);
        Debug.DrawLine(transform.position, ray.point, Color.magenta);
    }
    void Fire(){

        fireTime +=Time.deltaTime;
        if (fireTime > Random.Range(0.2f,1))
        {
            Instantiate(Bullet,transform.position,Quaternion.identity);
            fireTime = 0;
        }
    }
    public Vector2 getDirection(){
        return(Char.transform.position-transform.position).normalized;
    }

      public void TakeDamage(int damage){
        currentHealth-=damage;
        healthBar.SetHealth(currentHealth);
    }



    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "charsinglebullet")
        {
            TakeDamage(5);
        }
    }
    
}
