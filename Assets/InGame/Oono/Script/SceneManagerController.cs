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
    /// stage �̌Ăяo��
    /// Stage �ɂ�int�^��Stage�̔ԍ������
    /// </summary>
    public void StageLoadScene()
    {
        int Stage = GameManager.GetStageNum;

        SceneManager.LoadScene($"Stage{Stage}");
    }

    /// <summary>
    /// GameClear �̌Ăяo��
    /// </summary>
    public void StasgeClear()
    {
        SceneManager.LoadScene("StageClearScene");
    }

    /// <summary>
    /// GameOver �̌Ăяo��
    /// </summary>
    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    /// <summary>
    /// Taitle �̌Ăяo��
    /// </summary>
    public void Title()
    {
        SceneManager.LoadScene("TitleScene");
    }

    /// <summary>
    /// stage����O��Scene �̌Ăяo��
    /// </summary>
    public void StageStart()
    {
        SceneManager.LoadScene("StageStartScene");
    }

    /// <summary>
    /// Kari �̌Ăяo��
    /// </summary>
    public void Kari()
    {
        SceneManager.LoadScene("KScene");
    }
}
