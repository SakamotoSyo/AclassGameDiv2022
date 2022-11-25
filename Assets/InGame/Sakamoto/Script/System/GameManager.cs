using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    /// <summary>現在のステージ数</summary>
    public static int GetStageNum => stageNum;
    public static bool GetDifficulty => isDifficulty;
    
    /// <summary>現在のライフ</summary>
    public static int GetLife => life;

    [Tooltip("残機数")]
    private static int life = 2;
    [Tooltip("現在のステージ")]
    private static int stageNum = 1;
    [Tooltip("前回のステージをクリアしたかどうか")]
    private static bool isClear = false;
    [Tooltip("難易度が簡単かハードか")]
    private static bool isDifficulty;

    /// <summary>
    /// stageが終了したときに呼ぶ
    /// </summary>
    /// <param name="clear"></param>
    public static void StageEnd(bool clear)
    {
        isClear = clear;
        if (clear)
        {
            stageNum++;
            //Claerした場合のScene
            SceneManagerController.StasgeClear();
        }
        else
        {
            life--;
            if (life < 0)
            {
                //GameOverのSceneを呼び出す
                SceneManagerController.GameOver();

            }
            else 
            {
                //失敗した場合のScene
                SceneManagerController.StageFailedScene();
            }
        }
    }

    /// <summary>
    /// 難易度の設定
    /// </summary>
    public static void　SetDifficulty(bool difficulty) 
    {
        isDifficulty = difficulty;
    }

    /// <summary>
    /// ステージが切り替わる時にこの関数が呼ばれる
    /// 分岐させるSceneTimeLineが終わったら呼び出してほしい
    /// </summary>
    public static void NextScene()
    {
       SceneManagerController.StageLoadScene();
    }

    public static void ResetParmeter() 
    {
        if (isDifficulty)
        {
            //ハードの時はステージがリセットされる
            life = 2;
            stageNum = 1;
            AudioManager.Instance.Reset();
        }
        else 
        {
            life = 2;
            AudioManager.Instance.Reset();
        }
    }

}
