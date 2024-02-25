using System.Collections;
using System.Collections.Generic;
using UnityEditor.AnimatedValues;
using UnityEngine;

public class Kick : MonoBehaviour
{
    public float force = 100f;
    public GameObject ball;
    Rigidbody2D rbBall;

    private void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        rbBall = ball.GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball" && Input.GetKeyDown(KeyCode.K))
        {
            Vector2 pos = (collision.gameObject.transform.position - transform.position).normalized;
            rbBall.AddForce(pos * force, ForceMode2D.Impulse);
        }
    }
}
