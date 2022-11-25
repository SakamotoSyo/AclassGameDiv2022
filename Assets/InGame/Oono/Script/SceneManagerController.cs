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
    /// stage �̌Ăяo��
    /// Stage �ɂ�int�^��Stage�̔ԍ������
    /// </summary>
    public static void StageLoadScene()
    {
        int Stage = GameManager.GetStageNum;

        SceneManager.LoadScene($"Stage{Stage}");
        Debug.Log($"stage{Stage}�����[�h���܂�");
    }

    /// <summary>
    /// �X�e�[�W���N���A �̌Ăяo��
    /// </summary>
    public static void StasgeClear()
    {
        SceneManager.LoadScene("StageClearScene");
    }

    /// <summary>
    /// GameOver �̌Ăяo��
    /// </summary>
    public static void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
        GameManager.ResetParmeter();
    }

    /// <summary>
    /// Taitle �̌Ăяo��
    /// </summary>
    public static void Title()
    {
        SceneManager.LoadScene("TitleScene");
    }

    /// <summary>
    /// stage ����O��Scene �̌Ăяo��
    /// </summary>
    public static void StageStart()
    {
        SceneManager.LoadScene("StartScene");
    }

    /// <summary>
    /// �X�e�[�W�����s �̌Ăяo��
    /// </summary>
    public static void StageFailedScene()
    {
        SceneManager.LoadScene("StageFailedScene");
    }

    /// <summary>
    /// �S�X�e�[�W�̃N���A �̌Ăяo��
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
