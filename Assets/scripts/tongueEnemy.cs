using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tongueEnemy : MonoBehaviour
{
    float movement;
    public float speed = 5;
    public Transform startMarker;
    public Transform endMarker;
    float currentY;
    private float startTime;
    private float journeyLength;
    float t;
    public bool hastoTurn = false;

    private void Start()
    {
        startMarker = GameObject.Find("start").transform;
        endMarker = GameObject.Find("end").transform;

        startTime = Time.time;
        journeyLength = Vector2.Distance(startMarker.position, endMarker.position);

        currentY = gameObject.transform.position.y;
    }

    private void Update()
    {
        enemyMovement();

        if (transform.position.x == endMarker.position.x)
        {
            hastoTurn = false;
        }

        if (transform.position.x == startMarker.position.x)
        {
            hastoTurn = true;
        }
    }

    void enemyMovement()
    {
        if (hastoTurn == false)
        {
            t += Time.deltaTime;
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            transform.position = Vector2.Lerp(endMarker.position, startMarker.position, t);
        }

        if (hastoTurn == true)
        {
            t -= Time.deltaTime;
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            transform.position = Vector2.Lerp(endMarker.position, startMarker.position, t);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == ("sleepyGhost"))
        {
            Debug.Log("hit Player");
        }
    }
}
