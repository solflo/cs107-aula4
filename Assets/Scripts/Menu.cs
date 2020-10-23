using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{      
    public void PlayGame ()
    {
        SceneManager.LoadScene("galeria");
    }


    // Start is called before the first frame update
    void Start()
    {
        Scene cenaAtual = SceneManager.GetActiveScene();
        string nomeCenaAtual = cenaAtual.name;
        if (nomeCenaAtual == "menu")
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

    }


    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
    }
}
