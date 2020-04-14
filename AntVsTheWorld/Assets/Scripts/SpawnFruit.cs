using System.Collections.Generic;
using UnityEngine;

public class SpawnFruit : MonoBehaviour
{
    public List<GameObject> Fruits = new List<GameObject>();
    public float CoordX, CoordZ;
    public int NumFruits = 25;
    private float PlaceX, PlaceZ;

    // Start is called before the first frame update
    void Start()
    {
        int size = Fruits.Count;
        for(int i = 0; i < NumFruits; ++i)
        {
            GameObject randFruit = Fruits[Random.Range(0, size - 1)];
            PlaceX = Random.Range(-CoordX, CoordX);
            PlaceZ = Random.Range(-CoordZ, CoordZ);

            Instantiate(randFruit, new Vector3(PlaceX, 30, PlaceZ), Quaternion.identity);
        }
    }
}
