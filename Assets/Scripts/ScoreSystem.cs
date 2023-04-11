using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    private LevelingSystem _levelingSystem;
    
    [SerializeField] private Slider _scoreSlider;
    
    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _levelText;
    [SerializeField] private AudioClip bonusAudio;
    
    private int _score;

    private int _scoreForSlider;
    private int _maxScore;
    public int Score
    {
        get { return _score; }
        private set { _score = value; }
    }
    
    public int ScoreForSlider
    {
        get { return _scoreForSlider; }
        private set { _scoreForSlider = value; }
    }
    
    public int MaxScore
    {
        get { return _maxScore; }
        private set { _maxScore = value; }
    }

    private void Start()
    {
        _levelingSystem = GetComponent<LevelingSystem>();

        Score = 0;
        MaxScore = 100;
        ScoreForSlider = 0;

        _scoreText.text = "Очки: 0";
        _scoreText.text = "Уровень: 1";
    }

    public void IncreaseScore(int value) 
    {
        Score += value;
        _scoreText.text = "Очки: " + Score.ToString();
        
        ScoreForSlider += value;
        _scoreSlider.value = ScoreForSlider;
    }


    private void Update()
    {
        if (ScoreForSlider >= MaxScore)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        MaxScore = MaxScore * 2;
        AudioSource.PlayClipAtPoint(bonusAudio, transform.position);
        _levelingSystem.LevelUp();
        _levelText.text = "Уровень: " + _levelingSystem.Level.ToString();
        ScoreForSlider = 0;
    }
}
