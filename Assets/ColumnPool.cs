﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ColumnPool : MonoBehaviour {

    public float spawnRate = 4f;
    public int columnPoolSize = 5;
    public float columnYMin = -2f;
    public float columnYMax = 2f;

    private float timeSinceLastSpawn;
    private float spawnXPos = 10f;
    private int currentColumn = 0;

    public GameObject columnPrefab;

    private GameObject[] columns;
    private Vector2 objectPoolPosition = new Vector2(-15,-25f);

	// Use this for initialization
	void Start () {

        columns = new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++) {
            columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {

        timeSinceLastSpawn += Time.deltaTime;

        if (!GameControl.Instance.isGameOver && timeSinceLastSpawn >= spawnRate) {
            timeSinceLastSpawn = 0;

            float spawnYPos = Random.Range(columnYMin, columnYMax);
            columns[currentColumn].transform.position = new Vector2(spawnXPos, spawnYPos);

            currentColumn++;

            if (currentColumn >= columnPoolSize) { currentColumn = 0; }
        }
	
	}
}
