using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneButton : MonoBehaviour
{

    public SceneManagerController sceneManager;

    // Start is called before the first frame update
    public void Ls()
    {
        sceneManager.Kari();
    }
}
