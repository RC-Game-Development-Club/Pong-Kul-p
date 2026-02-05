using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseRed : MonoBehaviour
{
    public int blueScore;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            blueScore += 1;
            collision.gameObject.GetComponent<Ball>().BallStart();
        }
    }

}
