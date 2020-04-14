﻿using System.Collections.Generic;
using UnityEngine;

public class SpawnFruit : MonoBehaviour
{
    public List<GameObject> Fruits = new List<GameObject>();
    public float StartX, EndX, StartZ, EndZ;
    public int NumFruits = 50;
    private float PlaceX, PlaceZ;

    // Start is called before the first frame update
    void Start()
    {
        int size = Fruits.Count;
        for(int i = 0; i < NumFruits; ++i)
        {
            GameObject randFruit = Fruits[Random.Range(0, size - 1)];
            PlaceX = Random.Range(StartX, EndX);
            PlaceZ = Random.Range(StartZ, EndZ);
            Instantiate(randFruit, new Vector3(PlaceX, 20, PlaceZ), Quaternion.identity);
        }
    }
}
