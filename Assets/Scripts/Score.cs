using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    public int points;
    public TextMeshPro score;

    private void OnTriggerEnter2D(Collider2D other)
    {
        points += 1;
        score.SetText(points.ToString("0"));
    }
}
