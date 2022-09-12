using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;
    public KeyCode upKey;
    public KeyCode downKey;
    void Update()
    {
        Vector2 position = transform.position;

        if(Input.GetKey(upKey))
        {
            position.y += Time.deltaTime * speed;
        }

        if(Input.GetKey(downKey) && position.y > -4f)
        {
            position.y -= Time.deltaTime * speed;
        }

        transform.position = position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        ResetPosition( );
    }

    public void ResetPosition()
    {
        transform.position = new Vector2(transform.position.x, -4);
    }
}
