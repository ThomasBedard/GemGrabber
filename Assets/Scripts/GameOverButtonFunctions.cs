using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtonFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    public void Game_Quit()
    {
        //Application.Quit();
        EditorApplication.isPlaying = false;
    }
}
