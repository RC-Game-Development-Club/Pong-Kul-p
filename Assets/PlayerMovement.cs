using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed;
    private string name;
    private string axisName;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        name = gameObject.name;
        speed = 5f;
        if (name == "Player 1")
        {
            axisName = "Vertical";
        }
        else
        {
            axisName = "Vertical2";
        }
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxisRaw(axisName);
        rb.velocity = new Vector2(0, vertical) * speed;
    }
}
