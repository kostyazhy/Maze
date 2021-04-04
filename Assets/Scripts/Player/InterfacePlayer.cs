using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfacePlayer : MonoBehaviour
{
    public int Score;
    private int _maxScore = 500;
    public float Health;
    public int Level;
    public GameObject PositionFinish;

    public Text ScoreText;
    public Text LevelText;
    public Text HealthText;

    public void AddScore()
    {
        Score = Score + 100;
        Debug.Log("Score: " + Score);
        ScoreText.text = "Score: " + Score;
        if (Score == _maxScore) {
            AddLevel();
            _maxScore = _maxScore + 500;
        }
    }

    private void AddLevel()
    {
        Level = Level + 1;
        Debug.Log("Level: " + Level);
        LevelText.text = "Level: " + Level;
    }

    public void Hit()
    {
        Health = Health - 10.5f;

        Debug.Log("Health: " + Health);
        HealthText.text = "Health: " + Health;
    }
}
