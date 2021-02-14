using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public int NumberLevel;

    public void NextLevel(int numberLevel)
    {
        Application.LoadLevel(numberLevel);
    }
}
