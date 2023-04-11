using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelingSystem : MonoBehaviour
{
    private int _level;
    
    public int Level
    {
        get { return _level; }
        private set { _level = value; }
    }

    private void Start()
    {
        _level = 1;
    }

    public void LevelUp()
    {
        Level++;
    }
}
