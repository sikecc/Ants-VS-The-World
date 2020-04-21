using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    [SerializeField] private string scene;
    private AudioSource audio;
    public Animator transition;
    public float transitionTime = 1.0f;
    //public RawImage transitionImage;
    //public Canvas canvas;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            audio = GetComponent<AudioSource>();
            audio.Play();
            //RawImage image = Instantiate(transitionImage) as RawImage;
            //image.transform.SetParent(canvas.transform);

            //Invoke("changeScene", 5.0f);
            LoadNextLevel();
        }
    }

    private void LoadNextLevel()
    {
        StartCoroutine(LoadLevel());
    }

    private IEnumerator LoadLevel()
    {
        Debug.Log("setting trigger");
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(scene);
    }
}
