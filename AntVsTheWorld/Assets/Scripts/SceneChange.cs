﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    [SerializeField] private string scene;
    private AudioSource audio;
    public RawImage transitionImage;
    public Canvas canvas;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            audio = GetComponent<AudioSource>();
            audio.Play();
            RawImage image = Instantiate(transitionImage) as RawImage;
            image.transform.SetParent(canvas.transform);
            SceneManager.LoadScene(scene);
        }
    }
}
