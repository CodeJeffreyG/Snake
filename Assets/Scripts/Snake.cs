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
            currentDirection = up;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            currentDirection = left;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            currentDirection = down;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            currentDirection = right;
        }
    }

    public void FixedUpdate()
    {
        
    }

}
