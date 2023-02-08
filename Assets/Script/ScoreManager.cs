using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    [SerializeField] public int _scoreValue = 10;
    [SerializeField] public TMP_Text _scoreText;
    
    [SerializeField] private Player _player;
    //public int CurrentScore { get; set; }

    private void Awake()
    {
    //    instance = this;
    //CurrentScore = PlayerPrefs.GetInt("Score");
    }

    public void OnEnable()
    {
        _player.UpdateScore.AddListener(UpdateScoreValue);
    }
    
    public void OnDisable()
    {
        _player.UpdateScore.RemoveListener(UpdateScoreValue);
    }

    private void Start()
    {
        UpdateScoreValue();
    }

    //public void SetScore(int _scoreValue)
    //{
    //    PlayerPrefs.SetInt("Score", _scoreValue);
    //}

    public void UpdateScoreValue()
    {
        _scoreValue--;
        _scoreText.text = "Score : " + _scoreValue.ToString();
    }
    
}
    

