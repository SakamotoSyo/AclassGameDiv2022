using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialStageClearJudge : MonoBehaviour
{
    [Header("stage�̃N���A�܂ł̎���")]
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
            Debug.Log("����");
            GameManager.StageEnd(true);
            _timeCount = 0;
        }
    }
}
