using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallViewModel : MonoBehaviour
{
    BallModel ball;

    public BallViewModel(BallModel ball) 
    {
        this.ball = ball;
    }

    public Vector2 Direction 
    {
        get { return ball.direction; }
        set { ball.direction = value; }
    }

    public bool IsMoving 
    {
        get { return ball.isMoving; }
        set { ball.isMoving = value; }
    }

    public bool IsLaunched 
    {
        get { return ball.isLaunched; }
        set { ball.isLaunched = value; }
    }

    public float Speed 
    {
        get { return ball.speed; }
        set { ball.speed = value; }
    }

    public void Launch() 
    {
        ball.Launch();
    }
}
