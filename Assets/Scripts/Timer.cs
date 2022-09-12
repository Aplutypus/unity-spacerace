using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Timer : MonoBehaviour
{
    public float timer;
    public float countDown = 3f;
    
    public GameObject player1;
    public GameObject player2;
    public GameObject score;
    public GameObject gameOver;
    public TextMeshPro timerText;
    public TextMeshPro countDownText;

    void Update()
    {
        StartCountDown( );
        if(timer <= 0f)
            StopTimer( );
    }
    public void StartCountDown()
    {
        //travar movimento do player
        countDown -= Time.deltaTime;
        if(countDown > 0f)
        {
            countDownText.SetText(Mathf.RoundToInt(countDown).ToString( ));
        }
        if(countDown < 1f)
        {
            countDownText.SetText("Start");
            player1.GetComponent<Movement>( ).enabled = true;
            player2.GetComponent<Movement>( ).enabled = true;
            StartTimer( );
        }
        if(countDown <= 0f)
        {
            countDown = 0f;
            countDownText.GetComponent<TextMeshPro>( ).enabled = false;
        }
    }
    public void StartTimer()
    {
        timer -= Time.deltaTime;
        timerText.SetText(Mathf.RoundToInt(timer).ToString( ));
    }

    public void StopTimer()
    {
        timer = 0f;
        Time.timeScale = 0;
        score.SetActive(false);
        gameOver.SetActive(true);
    }

}
