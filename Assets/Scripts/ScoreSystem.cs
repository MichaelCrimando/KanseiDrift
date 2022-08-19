using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float multiplier = 10f;
    private float score = 0f;
    public const string HighScoreKey = "HighScore";

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * multiplier;

        scoreText.text = Mathf.FloorToInt(score).ToString();
    }

    private void OnDestroy(){
       int currentHighScore = PlayerPrefs.GetInt(HighScoreKey, 0); //Easy way to save basic info
       if(score > currentHighScore) {
           PlayerPrefs.SetInt(HighScoreKey, Mathf.FloorToInt(score));
       }
    }
}
