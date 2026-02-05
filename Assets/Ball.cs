using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    private float xVelocity;
    private float yVelocity;
    private Transform transform;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();
        BallStart();
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        rb.velocity = rb.velocity + rb.velocity.normalized * time * 0.001f;
    }
    public void BallStart()
    {
        time = 0;
        transform.position = new Vector3(0f, 0f, 0f);
        float randNum = Random.Range(-1f, 1f);
        if (randNum < 0)
        {
            xVelocity = -5f;
        }
        else
        {
            xVelocity = 5f;
        }
        yVelocity = Random.Range(-5f, 5f);
        rb.velocity = new Vector2(xVelocity, yVelocity);
    }
}
