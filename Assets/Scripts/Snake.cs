using System;
using JetBrains.Annotations;
using Unity.Mathematics;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Snake : MonoBehaviour
{
    [SerializeField] Transform snakeTransform;
    Vector2 currentDirection = Vector2.right;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Up is pressed");
            currentDirection = Vector2.up;
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Left is pressed");
            currentDirection = Vector2.left;
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Right is pressed");
            currentDirection = Vector2.down;
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Down is pressed");
            currentDirection = Vector2.right;
        }
    }

    public void FixedUpdate()
    {
        snakeTransform.position = new Vector3(
            Mathf.Round(snakeTransform.position.x) + currentDirection.x,
            Mathf.Round(snakeTransform.position.y) + currentDirection.y,
            0
        );



    }

}
