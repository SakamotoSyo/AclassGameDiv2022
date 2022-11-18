using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary>現在のステージ数</summary>
    public static int GetStageNum => StageNum;

    [Tooltip("残機数")]
    private static int Life = 2;
    private static int StageNum = 1;

    /// <summary>
    /// stageが終了したときに呼ぶ
    /// </summary>
    /// <param name="clear"></param>
    public void StageEnd(bool clear)
    {
        if (clear)
        {
            StageNum++;
        }
        else
        {
            Life--;
        }

        //分岐stageに入る前のSceneを呼び出す
        //LoadScript.LoadScene(SceneToBeBranched)
    }

    /// <summary>
    /// ステージが切り替わる時にこの関数が呼ばれる
    /// 分岐させるSceneTimeLineが終わったら呼び出してほしい
    /// </summary>
    private void NextScene()
    {
        //LoadScript.LoadScene(StageNum)
    }

}
