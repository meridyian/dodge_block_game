using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //public GameObject go;

    void Start()
    {
        //go.GetComponent<Camera>();
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
        //gameObject.GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
    }

    void Update()
    {
        if(transform.position.y < -2f)
        {
            Destroy(gameObject);
        }
    }
}
