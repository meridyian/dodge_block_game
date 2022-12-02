using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class RestartButton : MonoBehaviour
{
    public Block block;

    public void Restart()
    {
        Block.score = 0;
        SceneManager.LoadScene("Main Level");
    }
}
