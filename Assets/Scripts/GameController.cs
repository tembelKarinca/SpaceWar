using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject resPanel;
    public GameObject enemyBoss;
    public GameObject EnemyHealthBar;
    public RandomSpawner RandomSpawn;

    public TextMeshProUGUI scoreText;

    int score = 0;

private void Start() {
    RandomSpawn = GameObject.FindGameObjectWithTag("spawner").GetComponent<RandomSpawner>();
}

    void Update() {
        scoreText.text ="Score  " + score;
        if (score % 500 == 0 && score != 0)
        {
            enemyBoss.SetActive(true);
            EnemyHealthBar.SetActive(true);
          //  RandomSpawn.count=5;
          //  RandomSpawn.SetActive(false);
        }
        else
        {
           
            //EnemyHealthBar.SetActive(false);
          //  RandomSpawn.SetActive(true);
           // RandomSpawn.count=0;
        }
    }

    public void AddScore(int point)
    {
        score+=point;

    }

    public void RestartPanelShow()
    {
        resPanel.SetActive(true);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(0);
    }
}
