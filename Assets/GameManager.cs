using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Block block;
    public Player playerScript;
    public Canvas deathCanvas;
    public Canvas scoreCanvas;

    public Text currentScore;
    public Text totalScore;

    // to give slowmotion effect

    public GameObject player;

    public void Update()
    {

        currentScore.text = "Score: " + Block.score.ToString();
    }
    public void EndGame()
    {

        totalScore.text = "Total Score : " + Block.score.ToString();
 
        scoreCanvas.gameObject.SetActive(false);
        deathCanvas.gameObject.SetActive(true);
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * playerScript.slowness;
        player.gameObject.SetActive(false);
    }



}
