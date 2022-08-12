using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("w") || Input.GetKeyDown("s"))
        {
            FindObjectOfType<Audiomanager>().Play("FootSteps");
        }

        if (Input.GetKeyDown("space"))
        {
            FindObjectOfType<Audiomanager>().Play("Jump");
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            FindObjectOfType<Audiomanager>().Play("Sprint");
        }
        if (Input.GetMouseButtonDown(0))
        {
            FindObjectOfType<Audiomanager>().Play("GunShot");
        }
        if (Input.GetKeyDown("r"))
        {
            FindObjectOfType<Audiomanager>().Play("Reload");
        }

    }
}
