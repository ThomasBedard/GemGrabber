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
        //int side = Random.Range(0, 2);
        //if (side == 0)
        //{
            //right side
          //  position = new Vector2(Random.Range(13, 29), Random.Range(14, -14));
        //}
        //else
        //{
            //left side
          //  position = new Vector2(Random.Range(15, -27), Random.Range(14, -14));
        //}

        for (int i = 0; i < 1; i++)
        {
           // if (gem.transform.position.x == player.transform.position.x)
            //{

              //  position = new Vector2(Random.Range(-16, 27), Random.Range(-11, 9));

                if(position.x <= camera.transform.position.x + 2 && position.y <= camera.transform.position.y + 2)
                {
                    int sid = Random.Range(0, 2);
                    if (sid == 0)
                    {
                        //right side
                        position = new Vector2(Random.Range(13, 29), Random.Range(13, -13));
                    }
                    else
                    {
                        //left side
                        position = new Vector2(Random.Range(15, -27), Random.Range(13, -13));
                    }
                i++;
                //}
            }
            else
            {
                int sid = Random.Range(0, 2);
                if (sid == 0)
                {
                    //right side
                    position = new Vector2(Random.Range(13, 29), Random.Range(14, -13));
                }
                else
                {
                    //left side
                    position = new Vector2(Random.Range(15, -27), Random.Range(14, -13));
                }
                i++;
            }
            
        }

        Instantiate(gem, position, Quaternion.identity);
    }

}

