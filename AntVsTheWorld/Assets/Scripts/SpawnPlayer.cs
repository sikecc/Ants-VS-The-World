using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject character;
    public float x;
    public float y;
    public float z;
    void Start()
    {
        Instantiate(character, new Vector3(x, y, z), Quaternion.identity);
    }
}
