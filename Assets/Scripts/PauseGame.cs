using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    // link for waves -> https://www.deviantart.com/igorsandman/art/112-365-pixels-Wave-598008533
    [SerializeField]
    private bool isPaused = false;

    [SerializeField]
    private GameObject pauseCanvas;

    //private Button pauseButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                ResumeMe();
            }
            else
            {
                PauseMe();
            }
        }
    }
    public void PauseMe()
    {
        Time.timeScale = 0;//freeze time
        pauseCanvas.SetActive(true);
        isPaused = true;
    }

    public void ResumeMe()
    {
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
        isPaused = false;
    }
}
