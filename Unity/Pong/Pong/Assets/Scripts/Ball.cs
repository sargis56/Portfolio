using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public float speed = 30;
    Vector2 startPos;

    void Start()
    {
        int rand = Random.Range(1, 3);
        if (rand == 1)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
        }
        startPos = transform.position;
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "paddleLeft")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);

            Vector2 dir = new Vector2(1, y).normalized;

            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        if (collision.gameObject.name == "paddleRight")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);

            Vector2 dir = new Vector2(-1, y).normalized;

            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        if ((collision.gameObject.name == "rightWall") || (collision.gameObject.name == "leftWall"))
        {
            transform.position = startPos;
            int rand = Random.Range(1, 3);
            if (rand == 1)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
            }
        }
    }

}
