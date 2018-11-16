using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class RepeatingBackground : MonoBehaviour {

    private BoxCollider2D groundCollider;
    private float groundHorizontallength;

	// Use this for initialization
	void Start () {

        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontallength = groundCollider.size.x;
	
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x < -groundHorizontallength) {
            RepositionBackground();
        }
	
	}

    private void RepositionBackground() {

        Vector2 groundoffset = new Vector2(groundHorizontallength * 2, 0);
        transform.position = (Vector2)transform.position + groundoffset;

    }
}
