using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class EnnemyFollowPlayer : MonoBehaviour
{
    public Transform player;

    private Rigidbody2D rb2d;

    public float speed;

    private Vector2 move;

    private Vector3 previousPosition;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(wait());
        rb2d = GetComponent<Rigidbody2D>();
        player = GameObject.Find("player_0").transform;
        previousPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position != previousPosition)
        {
            if (player)
            {
                Vector3 direction = (player.position - transform.position).normalized;
                move = direction;
            }
        }

        
    }

    private void FixedUpdate()
    {
        if (player)
        {
            rb2d.velocity = new Vector2(move.x, move.y) * speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == GameObject.Find("player_0"))
        {
            SceneManager.LoadScene("GameOver");
        }
        //EditorApplication.isPlaying = false;
    }
}
