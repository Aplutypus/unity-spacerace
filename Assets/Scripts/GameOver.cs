using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TextMeshPro win;
    public TextMeshPro scoreP1;
    public TextMeshPro scoreP2;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            RestartGame( );
        }
    }

    private void OnMouseDown()
    {
        RestartGame( );
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void SetGameOverScreen(int scorep1, int scorep2, string player)
    {
        gameObject.SetActive(true);
        SetWinText(player);
        SetPlayer1ScoreText(scorep1);
        SetPlayer2ScoreText(scorep2);
    }

    private void SetPlayer1ScoreText(int score)
    {
        scoreP1.SetText(score.ToString( ));
    }

    private void SetPlayer2ScoreText(int score)
    {
        scoreP2.SetText(score.ToString( ));
    }

    private void SetWinText(string player)
    {
        win.SetText(player);
    }

}
