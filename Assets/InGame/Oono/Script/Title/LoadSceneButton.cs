using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneButton : MonoBehaviour
{
    [SceneName]
    [SerializeField] string _sceneName;

    public AudioClip se;
    AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    public void Ls()
    {
        SceneManagerController.LoadScene(_sceneName);
    }

    public void Audio()
    {
        //AudioSource.PlayClipAtPoint(se, transform.position);
        audioSource.PlayOneShot(se);

        Invoke("Ls", 1.0f);
    }

    public void ResetPar()
    {
        GameManager.ResetParmeter();
    }
}
