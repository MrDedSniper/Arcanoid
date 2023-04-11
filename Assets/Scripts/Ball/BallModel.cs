using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallModel : MonoBehaviour
{
    public float speed = 8f;
    public Vector2 direction = Vector2.one.normalized;
    public bool isMoving = false;
    public bool isLaunched = false;

    public void Launch() {
        isMoving = true;
        direction = Vector2.up;
    }
}
