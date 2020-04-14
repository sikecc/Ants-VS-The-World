using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    public int startingLives;
    private int lifeCounter;

    private Text theCounterText;

    // Start is called before the first frame update
    void Start()
    {
        theCounterText = GetComponent<Text>();
        lifeCounter = startingLives;
    }

    // Update is called once per frame
    void Update()
    {
        theCounterText.text = "x " + lifeCounter;
    }

    public void GiveLife()
    {
        lifeCounter++;
    }

    public void TakeLife()
    {
        lifeCounter--;
    }
}
