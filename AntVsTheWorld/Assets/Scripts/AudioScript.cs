using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public static AudioClip addPoint, eating;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        addPoint = Resources.Load<AudioClip>("addPoint");
        eating = Resources.Load<AudioClip>("eating");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "addPoint":
                audioSrc.PlayOneShot(addPoint);
                break;
            case "eating":
                audioSrc.PlayOneShot(eating);
                break;
        }
    }
}
