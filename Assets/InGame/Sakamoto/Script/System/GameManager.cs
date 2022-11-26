using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    /// <summary>���݂̃X�e�[�W��</summary>
    public static int GetStageNum => stageNum;
    public static bool GetDifficulty => isDifficulty;
    
    /// <summary>���݂̃��C�t</summary>
    public static int GetLife => life;

    [Tooltip("�c�@��")]
    private static int life = 2;
    [Tooltip("���݂̃X�e�[�W")]
    private static int stageNum = 1;
    [Tooltip("�O��̃X�e�[�W���N���A�������ǂ���")]
    private static bool isClear = false;
    [Tooltip("��Փx���ȒP���n�[�h��")]
    private static bool isDifficulty;

    /// <summary>
    /// stage���I�������Ƃ��ɌĂ�
    /// </summary>
    /// <param name="clear"></param>
    public static void StageEnd(bool clear)
    {
        isClear = clear;
        if (clear)
        {
            stageNum++;
            //Claer�����ꍇ��Scene
            SceneManagerController.StasgeClear();
        }
        else
        {
            life--;
            if (life < 0)
            {
                //GameOver��Scene���Ăяo��
                SceneManagerController.GameOver();

            }
            else 
            {
                //���s�����ꍇ��Scene
                SceneManagerController.StageFailedScene();
            }
        }
    }

    /// <summary>
    /// ��Փx�̐ݒ�
    /// </summary>
    public static void�@SetDifficulty(bool difficulty) 
    {
        isDifficulty = difficulty;
    }

    /// <summary>
    /// �X�e�[�W���؂�ւ�鎞�ɂ��̊֐����Ă΂��
    /// ���򂳂���SceneTimeLine���I�������Ăяo���Ăق���
    /// </summary>
    public static void NextScene()
    {
       SceneManagerController.StageLoadScene();
    }

    public static void ResetParmeter() 
    {
        if (isDifficulty)
        {
            //�n�[�h�̎��̓X�e�[�W�����Z�b�g�����
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
