using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneTitle : MonoBehaviour
{
    int i;
    [SceneName]
    [SerializeField] string _sceneName;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && i < 1)
        {
            i = i + 1;
            SceneManagerController.LoadScene(_sceneName);
        }
    }
}
