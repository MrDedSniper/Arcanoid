using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    [SerializeField] private Text _startText;
    [SerializeField] private Text _endText;

    private void Awake()
    {
        _startText.gameObject.SetActive(true);
        _endText.gameObject.SetActive(false);
    }
    
    public void GameStartUI()
    {
        _startText.gameObject.SetActive(false);
    }

    public void SetEndingUI()
    {
        _endText.gameObject.SetActive(true);
    }
}
