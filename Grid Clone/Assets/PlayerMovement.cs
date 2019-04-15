using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static Vector2 gapLocation;
    //public GameObject gapTest;
    // Start is called before the first frame update
    void Start()
    {

      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            gapLocation = new Vector2(transform.position.x, transform.position.y);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
           
            transform.position += new Vector3(-1, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            transform.position += new Vector3(1, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            transform.position += new Vector3(0, 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
           
            transform.position += new Vector3(0, -1);
        }
       

    }
}
