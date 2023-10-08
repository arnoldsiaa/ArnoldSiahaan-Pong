using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        /*Debug.Log("TEST "+ movement);*/
        rig.velocity = movement;
    }

    public void ActivePUPaddle()
    {
        Vector2 newScale = transform.localScale;
        newScale.y *= 2f;
        transform.localScale = newScale;
    }

    public void DeactivePUPaddle()
    {
        Vector2 newScale = transform.localScale;
        newScale.y /= 2f;
        transform.localScale = newScale;
    }
    public void ActiveSpeedPU()
    {
        speed *= 2;
    }
}
