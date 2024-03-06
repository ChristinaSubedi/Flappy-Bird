using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//for ScoreText
using UnityEngine.SceneManagement; //For loading scene

public class LogicScript : MonoBehaviour
{
	public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("increase Score")]//For debugging purpose
    public void addScore(int scoreToAdd){
        playerScore += scoreToAdd;
        scoreText.text= playerScore.ToString();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//Reload the curr scene
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
    }

}
