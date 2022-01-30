using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{

    // Array that holds all the shapes
    public GameObject[] shapes;

    public void SpawnShape()
    {
        // Generate a random index
        int shapeIndex = Random.Range(0, 6);

        // Create the shape at the ShapeSpawners location
        Instantiate(shapes[shapeIndex],
            transform.position,
            Quaternion.identity);
    }

    // Use this for initialization
    void Start()
    {

        // Spawn the default first shape
        SpawnShape();
    }

    // Update is called once per frame
    void Update()
    {

    }
}