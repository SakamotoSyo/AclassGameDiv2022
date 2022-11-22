using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class TutorialStageClearJudge : MonoBehaviour
{
    [Header("stage‚ÌƒNƒŠƒA‚Ü‚Å‚ÌŽžŠÔ")]
    [SerializeField] float _setStageClearTime;
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
        if (0 >= _clearTimeCount.Value) 
        {
            GameManager.StageEnd(true);
            _clearTimeCount.Value = 0;
        }
    }
}
