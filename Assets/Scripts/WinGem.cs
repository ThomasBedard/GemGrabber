using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGem : MonoBehaviour
{
    [SerializeField]
    private int SceneNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneNumber);
        //EditorApplication.isPlaying = false;
    }

}
