using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerViewModel : MonoBehaviour
{
    
    public static PlayerViewModel instance;
    
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        instance.transform.position = new Vector2(0, 0);
    }
}
