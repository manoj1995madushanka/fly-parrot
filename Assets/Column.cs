﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Column : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other) {

        if (other.GetComponent<Bird>() != null) {

            GameControl.Instance.Score();

        }

    }
}