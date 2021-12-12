using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameControl : MonoBehaviour
{
    public static GameControl instance;

    public GameObject livesHolder;

    int score = 0;
    int score2 = 4; // karkkien m‰‰r‰ tasolla 1
    int lives = 3;
    
    int scoremaxlevel1 = 4; // karkkien m‰‰r‰ tasolla 1
    int scoremaxlevel2 = 9; // karkkien m‰‰r‰ tasolla 2 (5) + karkkien m‰‰r‰ tasolla 1

    //bool gameOver = false;

    public Text scoreText;

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
        //haetaan ladatun scenen buildindex ja tallennetaan se muuttujaan y
        int y = SceneManager.GetActiveScene().buildIndex;

        // Tarkistetaan, ollaanko viel‰ tasolla 1, jos ei , hyp‰t‰‰n t‰m‰n ehtolausekkeen yli
        if (y < 2) 
        { 

            if (score < scoremaxlevel1) 
            { 
                score++;                
                scoreText.text = score.ToString(); //score int -arvosta string -arvoksi
            
                if (score == scoremaxlevel1) //kun 1 tason karkit on ker‰tty
                {                
                    SceneManager.LoadScene("Level2");
                }
            
            }
        }
        
        if (y > 1) // tarkistetaan, ollaanko tasolla, jonka buildindex > 1, esim tasolla Level2 (y=2)
        { 
            score2++;
            scoreText.text = score2.ToString(); // muutetaan samalla score int -arvosta string -arvoksi
            //print(score2);

            if (score2 == scoremaxlevel2)
            {
                SceneManager.LoadScene("Win");
            }
        }


    }

    public void DecreaseLife()
    {
        if(lives > 0)
        {
            lives--;
            //print(lives);

            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);

        }
        if(lives <= 0)
        {
            //gameOver = true;

            GameOver();
        }       
        
    }
    public void GameOver()
    {
        //print("GameOver()");
        SceneManager.LoadScene("GameOver");
    }

}
