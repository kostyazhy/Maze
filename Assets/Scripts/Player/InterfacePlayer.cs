using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfacePlayer : MonoBehaviour
{
    public int Score;
    public float Health;
    public int Level;
    public GameObject PositionFinish;

    public void AddScore()
    {
        Score = Score + 100;
        Debug.Log("Score: " + Score);
    }
}
