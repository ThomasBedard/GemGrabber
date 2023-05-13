using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class GemGenerator : MonoBehaviour
{

    [SerializeField]
    private GameObject gem;
    // Start is called before the first frame update
    void Start()
    {
        spawnObject();
    }

    public void spawnObject()
    {
        
        Vector2 position;

        position = new Vector2(Random.Range(-16,20),Random.Range(-11,9));

        Instantiate(gem, position, Quaternion.identity);
    }

}

