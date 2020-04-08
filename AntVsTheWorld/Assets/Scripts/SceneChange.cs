using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] private string scene;
    private AudioSource audio;
    private void OnTriggerEnter(Collider other)
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
        SceneManager.LoadScene(scene);
    }
}
