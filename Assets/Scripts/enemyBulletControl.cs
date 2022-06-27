using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletControl : MonoBehaviour
{
    mobilEnemyControl Enemy;
    Rigidbody2D rgb;
  

    void Start()
    {
        Enemy = GameObject.FindGameObjectWithTag("enemyboss").GetComponent<mobilEnemyControl>();
        rgb = GetComponent<Rigidbody2D>();
        rgb.AddForce(Enemy.getDirection()*1000);
       
    }
    private void onTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "barrier")
        {
            
            Destroy (gameObject);
        }
            
        
    }

  

   
}
