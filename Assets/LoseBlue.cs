using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseBlue : MonoBehaviour
{
    public int redScore;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            redScore += 1;
            collision.gameObject.GetComponent<Ball>().BallStart();
        }
    }
}
