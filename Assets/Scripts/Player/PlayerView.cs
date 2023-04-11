using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private PlayerModel _model;
    
    void Start()
    {
        var rigidbody = GetComponent<Rigidbody2D>();
        _model = new PlayerModel(rigidbody);
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            _model.MoveLeft();
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            _model.MoveRight();
        }
        else
        {
            _model.StopMoving();
        }
    }
}
