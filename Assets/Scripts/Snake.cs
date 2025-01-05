using System;
using JetBrains.Annotations;
using UnityEngine;

public class Snake : MonoBehaviour
{
    [SerializeField] Transform snakeTransform;
    Vector2 currentDirection;
    public Vector2 right = Vector2.right;
    public Vector2 left = Vector2.left;
    public Vector2 down = Vector2.down;
    public Vector2 up = Vector2.up;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Up is pressed");
            currentDirection = up;
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Left is pressed");
            currentDirection = left;
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Right is pressed");
            currentDirection = down;
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Down is pressed");
            currentDirection = right;
        }
    }

    public void FixedUpdate()
    {
        float currentX = snakeTransform.position.x;
        float currentY = snakeTransform.position.y;
        snakeTransform.position = new Vector3(
            Mathf.Round(currentX + currentDirection.x),
            Mathf.Round(currentY + currentDirection.y),
            0
        );

        Debug.Log(snakeTransform.position);
        Debug.Log("Current direction: " + currentDirection);

    }

}
