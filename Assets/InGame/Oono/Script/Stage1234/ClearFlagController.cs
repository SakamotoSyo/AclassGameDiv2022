using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearFlagController : MonoBehaviour
{
    [SceneName]
    [SerializeField] string _sceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SceneManagerController.LoadScene(_sceneName);
        }
    }
}
