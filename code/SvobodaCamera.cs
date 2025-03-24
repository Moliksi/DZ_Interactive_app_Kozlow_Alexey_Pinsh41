using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SvobodaCamera : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    private float dirX, dirY;
    [SerializeField] float moveSpeed;
    public Joystick joystick;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        dirX = joystick.Horizontal;
        dirY = joystick.Vertical;
        rb.velocity = new Vector2(dirX * moveSpeed, dirY * moveSpeed);
    }
}
