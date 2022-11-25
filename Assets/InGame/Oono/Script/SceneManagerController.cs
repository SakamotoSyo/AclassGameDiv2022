using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerController
{

    //public static SceneManagerController instance;

    //private void Awake()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //        DontDestroyOnLoad(this.gameObject);
    //    }
    //    else
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}

    /// <summary>
    /// stage の呼び出し
    /// Stage にはint型でStageの番号を入力
    /// </summary>
    public static void StageLoadScene()
    {
        int Stage = GameManager.GetStageNum;

        SceneManager.LoadScene($"Stage{Stage}");
        Debug.Log($"stage{Stage}をロードします");
    }

    /// <summary>
    /// ステージをクリア の呼び出し
    /// </summary>
    public static void StasgeClear()
    {
        SceneManager.LoadScene("StageClearScene");
    }

    /// <summary>
    /// GameOver の呼び出し
    /// </summary>
    public static void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
        GameManager.ResetParmeter();
    }

    /// <summary>
    /// Taitle の呼び出し
    /// </summary>
    public static void Title()
    {
        SceneManager.LoadScene("TitleScene");
    }

    /// <summary>
    /// stage 分岐前のScene の呼び出し
    /// </summary>
    public static void StageStart()
    {
        SceneManager.LoadScene("StartScene");
    }

    /// <summary>
    /// ステージを失敗 の呼び出し
    /// </summary>
    public static void StageFailedScene()
    {
        SceneManager.LoadScene("StageFailedScene");
    }

    /// <summary>
    /// 全ステージのクリア の呼び出し
    /// </summary>
    public static void AllStageClearScene()
    {
        SceneManager.LoadScene("AllStageClearScene");
        GameManager.ResetParmeter();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="scene"></param>
    public static void LoadScene(string scene) 
    {
        SceneManager.LoadScene(scene);
    }
}
