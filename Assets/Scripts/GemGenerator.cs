using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class GemGenerator : MonoBehaviour
{

    [SerializeField]
    private GameObject gem;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        spawnObject();
    }

    public void spawnObject()
    {
        
        Vector2 position;

       position = new Vector2(Random.Range(-16,20),Random.Range(-11,9));

        for (int i = 0; i < 1; i++)
        {
            if (gem.transform.position.x == player.transform.position.x)
            {

                position = new Vector2(Random.Range(-16, 20), Random.Range(-11, 9));

                if(position.x <= camera.transform.position.x && position.y <= camera.transform.position.y)
                {
                    position = new Vector2(Random.Range(-14, -27), Random.Range(0, 2));
                }
            }
            else
            {
                position = new Vector2(Random.Range(-14, -27), Random.Range(0, 2));
                i++;
            }
            
        }

        Instantiate(gem, position, Quaternion.identity);
    }

}

