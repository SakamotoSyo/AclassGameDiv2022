using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneButton : MonoBehaviour
{
    [SceneName]
    [SerializeField] string _sceneName;

    // Start is called before the first frame update
    public void Ls()
    {
        SceneManagerController.LoadScene(_sceneName);
    }
}
