using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bird : MonoBehaviour {

    public float upforce = 200f;
    public bool isDead = false;

    private Rigidbody2D rb2d;
    private Animator animation;

	// Use this for initialization
	void Start () {

        rb2d = GetComponent<Rigidbody2D>();
        animation = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {

        if (isDead) { return; }
        if (Input.GetMouseButtonDown(0)) {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0, upforce));
            animation.SetTrigger("Flap");
        }

	}

    void OnCollisionEnter2D() {
        isDead = true;
        rb2d.velocity = Vector2.zero;
        animation.SetTrigger("Die");
        GameControl.Instance.Die();
    }

}
