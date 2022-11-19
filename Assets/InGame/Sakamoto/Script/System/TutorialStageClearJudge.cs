using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialStageClearJudge : MonoBehaviour
{
    [Header("stageのクリアまでの時間")]
    [SerializeField] float _stageClearTime;
    float _timeCount;
    void Start()
    {
        
    }

    void Update()
    {
        _timeCount += Time.deltaTime;
        if (_stageClearTime <= _timeCount) 
        {
            Debug.Log("うわ");
            GameManager.StageEnd(true);
            _timeCount = 0;
        }
    }
}
