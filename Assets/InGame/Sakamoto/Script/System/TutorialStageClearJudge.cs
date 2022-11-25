using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class TutorialStageClearJudge : MonoBehaviour
{
    [Header("stage�̃N���A�܂ł̎���")]
    [SerializeField] float _setStageClearTime;
    [Header("�N���A������S�N����")]
    [SerializeField] bool _isAllClear;
    //Model
    public IObservable<float> TimeChanged => _clearTimeCount;
    private readonly ReactiveProperty<float> _clearTimeCount = new ReactiveProperty<float>();

    void Start()
    {
        _clearTimeCount.Value = _setStageClearTime;
    }

    void Update()
    {
        _clearTimeCount.Value -= Time.deltaTime;
        if (0 >= _clearTimeCount.Value && !_isAllClear) 
        {
            GameManager.StageEnd(true);
            _clearTimeCount.Value = 0;
        }
        else if(0 >= _clearTimeCount.Value && _isAllClear)
        {
            SceneManagerController.AllStageClearScene();
            _clearTimeCount.Value = 0;
        }
    }
}
