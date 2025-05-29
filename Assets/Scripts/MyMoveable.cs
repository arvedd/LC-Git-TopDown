using System;
using UnityEngine;

public class MyMoveable : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 1;

    void Update()
    {
        UpdatePosition();
    }

    private void UpdatePosition()
    {
        transform.position = transform.position + direction * Time.deltaTime * speed;
    }

    public void setDirection(Vector3 value)
    {
        direction = value;
    }

    public void setDirection(Vector2 value)
    {
        direction.x = value.x;
        direction.y = value.y;
    }

    public void setDirection(float x, float y)
    {
        direction.x = x;
        direction.y = y;
    }

    internal void setXDirection(float v)
    {
        // throw new NotImplementedException();

        direction.x = v;
    }

     public Vector3 getNextPosition()
    {
       return transform.position + (direction * Time.deltaTime * speed);
    }

    internal void setYDirection(float v)
    {
        // throw new NotImplementedException();
        direction.y = v;
    }
}
