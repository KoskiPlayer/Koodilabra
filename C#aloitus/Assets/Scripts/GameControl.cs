using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;

    int score = 0;
    int lives = 3;

    bool gameOver = false;

    private void Awake()
    {
        instance = this;
    }


   public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void MainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void IncrementScore()
    {
        score++;
        //print(score);
    }

    public void DecreaseLife()
    {
        if(lives > 0)
        {
            lives--;
            print(lives);
        }
        if(lives <= 0)
        {
            gameOver = true;

            GameOver();
        }       
        
    }
    public void GameOver()
    {
        print("GameOver()");
    }

}
