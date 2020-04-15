using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    public int startingLives;
    private int lifeCounter;

    public GameObject gameOverScreen;
    public Player player;

    private Text theCounterText;

    // Start is called before the first frame update
    void Start()
    {
        theCounterText = GetComponent<Text>();
        lifeCounter = startingLives;

        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeCounter < 0)
        {
            gameOverScreen.SetActive(true);
            player.gameObject.SetActive(false);
        }
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
