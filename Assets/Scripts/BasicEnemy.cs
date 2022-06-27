using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
  RandomSpawner spawner;
  Player player;
  GameController controller;
  private void Start() {
    spawner = GameObject.FindGameObjectWithTag("spawner").GetComponent<RandomSpawner>();
    player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    controller = GameObject.FindGameObjectWithTag("screen").GetComponent<GameController>();

  }
  private void OnTriggerEnter2D(Collider2D other) {
      if (other.gameObject.tag=="charsinglebullet")
      {
          Destroy(gameObject);
          spawner.count-=1;
          player.currentHealth+=1;
          controller.AddScore(5);
      }
      if (other.gameObject.tag=="barrier")
      {
          Destroy(gameObject);
          spawner.count-=1;
      }
  }
}
