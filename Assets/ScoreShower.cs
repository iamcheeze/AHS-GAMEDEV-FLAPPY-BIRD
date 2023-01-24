using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreShower : MonoBehaviour
{
    PlayerCollisionDetection playerCollisionDetection;
    TextMeshProUGUI scoreText;

    void Start()
    {
        playerCollisionDetection = FindObjectOfType<PlayerCollisionDetection>();
        scoreText = this.gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        scoreText.text = playerCollisionDetection.score.ToString("0");
    }
}
