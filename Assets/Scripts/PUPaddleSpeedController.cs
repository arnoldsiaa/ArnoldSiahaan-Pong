using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleSpeedController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public PaddleController paddleLeft;
    public PaddleController paddleRight;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            paddleLeft.ActiveSpeedPU();
            paddleRight.ActiveSpeedPU();
            manager.RemovePowerUp(gameObject);
        }
    }
}
