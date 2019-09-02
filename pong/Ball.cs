using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 30;
    public float hitfactor(Vector2 ballposition, Vector2 racketposition, float racketheight)
    {
        return (ballposition.y - racketposition.y) / racketheight;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        float y = hitfactor(transform.position,
                           collision.transform.position,
                           collision.collider.bounds.size.y);
        Vector2 dir = new Vector2(1, y).normalized;
        GetComponent<Rigidbody2D>().velocity = dir * speed;

        if (collision.gameObject.name == "LeftRacket")
        {


            y = hitfactor(transform.position,
                                collision.transform.position,
                                collision.collider.bounds.size.y);


            Vector2 direction = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        if (collision.gameObject.name == "RightRacket")
        {


            y = hitfactor(transform.position,
                               collision.transform.position,
                               collision.collider.bounds.size.y);


            Vector2 direction = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        // Start is called before the first frame update
        void Start()
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;

        }

       

        }
    }

