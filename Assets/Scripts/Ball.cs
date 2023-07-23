using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private GameManager gameManager;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public Sprite[] _ballSprite;
    public float _jumpPower;
    public string _currentColor;
    void Start()
    {
        gameManager = GameManager.FindObjectOfType<GameManager>();
        RandomBall(3);
    }

    
    void Update()
    {
        
    }

    public void RandomBall(int _index)
    {
        switch (_index)
        {
            case 0: _currentColor = "Red";
                sr.sprite = _ballSprite[0];
                gameObject.tag = "Red";
                break;
            case 1:_currentColor = "Yellow";
                sr.sprite = _ballSprite[1];
                gameObject.tag = "Yellow";
                break;
            case 2: _currentColor = "Blue";
                sr.sprite = _ballSprite[2];
                gameObject.tag = "Blue";
                break;
            case 3:_currentColor = "Purple";
                sr.sprite = _ballSprite[3];
                gameObject.tag = "Purple";
                break;
            case 4:_currentColor = "Green";
                sr.sprite = _ballSprite[4];
                gameObject.tag = "Green";
                break;
            case 5:_currentColor = "Orange";
                sr.sprite = _ballSprite[5];
                gameObject.tag = "Orange";
                break;
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        rb.velocity = Vector3.up * _jumpPower;
        if (other.gameObject.tag != _currentColor)
        {
            gameManager.RestartGame();
        }
        else
        {
            gameManager._score += 1;
            int _randomNumber = Random.Range(0, 6);
            RandomBall(_randomNumber);
        }
    }
}
