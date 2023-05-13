using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    [SerializeField]
    private bool isStopped = false;

    [SerializeField]
    private GameObject startCanvas;

    

    private Button button;
    // Start is called before the first frame update
    void Start()
    {
       startCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isStopped)
            {
               StartGame();
            }
            else
            {
              PauseMe();
            }
        }
        // startButton.onClick.AddListener(StartGame());
    }

    public void PauseMe()
    {
        Time.timeScale = 0;//freeze time
        startCanvas.SetActive(true);
        isStopped = true;
    }
    public void StartGame()
    {
        Time.timeScale = 1;
        startCanvas.SetActive(false);
        isStopped = false;
    }
}
