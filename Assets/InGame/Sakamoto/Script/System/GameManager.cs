using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary>現在のステージ数</summary>
    public static int GetStageNum => stageNum;
    /// <summary>現在のライフ</summary>
    public static int GetLife => life;

    [Tooltip("残機数")]
    private static int life = 2;
    [Tooltip("現在のステージ")]
    private static int stageNum = 1;
    [Tooltip("前回のステージをクリアしたかどうか")]
    private static bool isClear = false;

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
        }
        else
        {
            life--;
            if (life < 0)
            {
                //GameOverのSceneを呼び出す
            }
            else 
            {
                //失敗した場合のScene
            }
        }
    }

    /// <summary>
    /// ステージが切り替わる時にこの関数が呼ばれる
    /// 分岐させるSceneTimeLineが終わったら呼び出してほしい
    /// </summary>
    public void NextScene()
    {
        //LoadScript.LoadScene(StageNum)
    }

}
