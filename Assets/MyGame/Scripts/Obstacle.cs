﻿using UnityEngine;

public class Obstacle : MonoBehaviour
{
Rigidbody2D rb;
[SerializeField] private float MoveSpeed;

private void Awake()
{
    rb = GetComponent<Rigidbody2D>();
}


// Update is called once per frame
void Update()
{
    //if obstacle's position x is < -15f it will be destroyed
    if(transform.position.x < -15f)
    {
        Destroy(gameObject);
}
        //if obstacle's position x is < -15f it will be destroyed
        if (transform.position.x > 15f)
        {
            Destroy(gameObject);
        }

    }



private void FixedUpdate()
{

    rb.velocity = Vector2.left * MoveSpeed;

}
}
