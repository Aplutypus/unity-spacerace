using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Manager : MonoBehaviour
{
    public Score p1;
    public Score p2;
    
    public GameOver gameOverScreen;
    public Asteroid asteroidPrefab;
    public Movement player1;
    public Movement player2;

    public GameObject asteroidSpawnPoint;

    private void Start()
    {
        Time.timeScale = 1;
        InvokeRepeating("RandomSpawn", 0f, 0.5f);
    }
    private void Update()
    {
        if(Time.timeScale == 0)
        {
            Whowon( );
            player1.ResetPosition( );
            player2.ResetPosition( );
            Destroy(asteroidSpawnPoint);
        }
    }
    void RandomSpawn()
    {
        asteroidPrefab.RandomSpawn(asteroidSpawnPoint.transform);
    }

    void Whowon()
    {
        if(p1.points > p2.points)
        {
            gameOverScreen.SetGameOverScreen(p1.points, p2.points, "Player 1 wins!");
        }
        else if(p2.points > p1.points)
        {
            gameOverScreen.SetGameOverScreen(p1.points, p2.points, "Player 2 wins!");
        }
        else
        {
            gameOverScreen.SetGameOverScreen(p1.points, p2.points, "It's a draw");
        }
    }
}
