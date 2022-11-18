using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void Ls()
    {
        SceneManager.LoadScene("KScene");
    }
}
