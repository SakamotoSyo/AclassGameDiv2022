using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary>���݂̃X�e�[�W��</summary>
    public static int GetStageNum => StageNum;

    [Tooltip("�c�@��")]
    private static int Life = 2;
    private static int StageNum = 1;

    /// <summary>
    /// stage���I�������Ƃ��ɌĂ�
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

        //����stage�ɓ���O��Scene���Ăяo��
        //LoadScript.LoadScene(SceneToBeBranched)
    }

    /// <summary>
    /// �X�e�[�W���؂�ւ�鎞�ɂ��̊֐����Ă΂��
    /// ���򂳂���SceneTimeLine���I�������Ăяo���Ăق���
    /// </summary>
    private void NextScene()
    {
        //LoadScript.LoadScene(StageNum)
    }

}
