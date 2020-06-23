using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject[] Yeet;
    private float PositionX;
    private int ObjectRand;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        ObjectRand = Random.Range(0, Yeet.Length);

        PositionX = Random.Range(5f, -7.5f);
        this.transform.position = new Vector3(PositionX, 0f, 10f);
        Instantiate(Yeet[ObjectRand], transform.position, transform.rotation);
    }
}
