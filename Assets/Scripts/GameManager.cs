using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public TMP_Text _scoreText;
    public int _score;
    void Start()
    {
        
    }

    
    void Update()
    {
        _scoreText.text = _score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
