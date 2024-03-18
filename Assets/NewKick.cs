using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewKick : MonoBehaviour
{
    public GameObject ball;
    public float force = 100f;
    Rigidbody2D rbBall;
    // Start is called before the first frame update
    void Awake()
    {
        rbBall = ball.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            print("°ø¿¡ ´êÀ½");

            if (Input.GetKey(KeyCode.K))
            {
                print("kick");
                Vector2 pos = (collision.gameObject.transform.position - transform.position).normalized;
                rbBall.AddForce(pos * force, ForceMode2D.Impulse);
            }
        }
    }
}
