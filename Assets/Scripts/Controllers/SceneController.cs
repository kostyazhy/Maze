﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    private GameObject _enemy;

    public GameObject SpawnPoint;

    void Update()
    {
        if (_enemy == null) {
            _enemy = Instantiate(enemyPrefab) as GameObject; 
            _enemy.transform.position = SpawnPoint.transform.position;
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);
        }
    }
}
