using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneManagerController : MonoBehaviour
{

    public static SceneManagerController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void StageLoadScene()
    {
        int Stage = GameManager.GetStageNum;

        SceneManager.LoadScene($"Stage{Stage}");
    }

    public void GameClear()
    {
        SceneManager.LoadScene("GameClearScene");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }
    public void Title()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void Kari()
    {
        Console.WriteLine("orz");
        SceneManager.LoadScene("KScene");
    }
}
