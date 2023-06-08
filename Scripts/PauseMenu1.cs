using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu1 : MonoBehaviour
{
    PauseMenu1 secondScript;


    // Start is called before the first frame update
    void Start()
    {
        secondScript = GameObject.Find("Pause_Menu_1").GetComponent<PauseMenu1>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main_Menu");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Tutorial");
        }
    }
}
