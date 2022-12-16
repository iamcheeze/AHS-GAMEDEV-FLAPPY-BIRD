using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    PlayerHealth pH;
    TextMeshProUGUI scoreText;

    private void Start()
    {
        pH = FindObjectOfType<PlayerHealth>();
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        scoreText.text = pH.score.ToString("0");
    }
}
