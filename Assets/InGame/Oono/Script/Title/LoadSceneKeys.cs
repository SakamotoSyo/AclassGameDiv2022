using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneKeys : MonoBehaviour
{
    int i;
    public SceneManagerController sceneManager;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && i < 1)
        {
            i = i + 1;
            sceneManager.Kari();
        }
    }
}
