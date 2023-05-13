using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime);
        transform.LookAt(player);
    }
}
