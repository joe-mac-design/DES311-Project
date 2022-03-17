using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))  
        {
            LoadScene();
        }
        if (Input.GetKeyDown(KeyCode.Q))  
        {
            QuitScene();
        }
    }

    void LoadScene () 
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    void QuitScene () 
    {
        #if UNITY_STANDALONE
        //Quit the application
        Application.Quit();
    #endif
        #if UNITY_EDITOR
        //Stop playing the scene
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
    }
}
