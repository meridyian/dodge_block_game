using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //public GameObject go;

    
    public static int score = 0;
    void Start()
    {
        
        //go.GetComponent<Camera>();
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
        //gameObject.GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
    }

    public void Update()
    {
        if (transform.position.y < -1.25f)
        {
            score += 50; 
            Destroy(gameObject);
        }
    }
}
