using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPrefabs : MonoBehaviour
{

    private float topBound = 30.0f;
    private float floorBound = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            // to destroy the projectile prefab
            Destroy(gameObject);
            Debug.Log("GAME OVER");
        }
        else if (transform.position.z < floorBound)
        {
            //to destroy the animal prefabs
            Destroy(gameObject);
            Debug.Log("GAME OVER");
        }
    }
}
