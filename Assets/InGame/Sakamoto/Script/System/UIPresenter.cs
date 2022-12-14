using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class UIPresenter : MonoBehaviour
{
    [Header("このSceneのUIを管理する")]
    [SerializeField] UIView _uiView;
    [Header("Timeを計測しているScript(Model)")]
    [SerializeField] TutorialStageClearJudge _clearJudge;

    void Start()
    {
        _clearJudge.TimeChanged.Subscribe(value => _uiView.SetTimer(value));
    }
}
