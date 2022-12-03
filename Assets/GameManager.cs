using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Block block;

    public Canvas deathCanvas;
    public Canvas scoreCanvas;

    public Text currentScore;
    public Text totalScore;

    // to give slowmotion effect
    public float slowness = 10f;
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
        StartCoroutine(RestartLevel());
        player.gameObject.SetActive(false);
    }



    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(1f / slowness);

        Time.timeScale = 1f;



        // after 1 sec
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
