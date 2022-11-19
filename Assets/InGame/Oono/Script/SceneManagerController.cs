using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    /// <summary>
    /// stage の呼び出し
    /// Stage にはint型でStageの番号を入力
    /// </summary>
    public void StageLoadScene()
    {
        int Stage = GameManager.GetStageNum;

        SceneManager.LoadScene($"Stage{Stage}");
    }

    /// <summary>
    /// GameClear の呼び出し
    /// </summary>
    public void StasgeClear()
    {
        SceneManager.LoadScene("StageClearScene");
    }

    /// <summary>
    /// GameOver の呼び出し
    /// </summary>
    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    /// <summary>
    /// Taitle の呼び出し
    /// </summary>
    public void Title()
    {
        SceneManager.LoadScene("TitleScene");
    }

    /// <summary>
    /// stage分岐前のScene の呼び出し
    /// </summary>
    public void StageStart()
    {
        SceneManager.LoadScene("StageStartScene");
    }

    /// <summary>
    /// Kari の呼び出し
    /// </summary>
    public void Kari()
    {
        SceneManager.LoadScene("KScene");
    }
}
