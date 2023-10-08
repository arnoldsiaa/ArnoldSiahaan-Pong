using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleSizeController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public PaddleController paddleLeft;
    public PaddleController paddleRight;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
                paddleLeft.ActivePUPaddle();
                paddleRight.ActivePUPaddle();
                manager.RemovePowerUp(gameObject);
        }
    }
}
