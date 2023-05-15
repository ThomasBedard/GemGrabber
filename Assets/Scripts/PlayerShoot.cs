using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] int maxBullets = 3;
    [SerializeField] float bulletSpeed = 10f;
    private int currentBullets = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) /*&& currentBullets < maxBullets*/)
        {
            FireBullet();
        }

        // Rotate the empty object towards the mouse cursor
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
    }

    void FireBullet()
    {
        //Vector2 position = new Vector2(10, 10); 
        // Instantiate the bullet object
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

        // Calculate the direction vector between the player's position and the mouse position
        Vector2 direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;

        // Set the velocity of the bullet according to the direction vector
        bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

        // Ignore collisions with the character's layer
        int characterLayer = LayerMask.NameToLayer("Character");
        //Physics2D.IgnoreLayerCollision(gameObject.layer, characterLayer, true);

        // Increment the bullet count and add an event listener to the bullet's OnBulletDestroyed event
        currentBullets++;
        bullet.GetComponent<BulletController>().OnBulletDestroyed += OnBulletDestroyed;

        // Reset layer collision ignore after a short delay
        StartCoroutine(ResetLayerCollisionIgnore(characterLayer));
    }

    IEnumerator ResetLayerCollisionIgnore(int layer)
    {
        yield return new WaitForSeconds(0.1f);
        //Physics2D.IgnoreLayerCollision(gameObject.layer, layer, false);
    }

    void OnBulletDestroyed()
    {
        currentBullets--;
    }
}
