using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public float speed = 10f;
    public delegate void BulletDestroyed();
    public event BulletDestroyed OnBulletDestroyed;
    public float lifetime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // If the bullet collides with an enemy, raise the OnBulletDestroyed event
        if (other.CompareTag("Enemy"))
        {
            //Destroy(other);
            Destroy(other.gameObject);
            Destroy(gameObject);
            // Call the OnBulletDestroyed event
            OnBulletDestroyed?.Invoke();
        }
    }
    void OnDestroy()
    {
        // Trigger the OnBulletDestroyed event when the bullet is destroyed
        OnBulletDestroyed?.Invoke();
    }
}
