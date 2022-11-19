using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class UIPresenter : MonoBehaviour
{
    [Header("����Scene��UI���Ǘ�����")]
    [SerializeField] UIView _uiView;
    [Header("Time���v�����Ă���Script(Model)")]
    [SerializeField] TutorialStageClearJudge _clearJudge;

    void Start()
    {
        _clearJudge.TimeChanged.Subscribe(value => _uiView.SetTimer(value));
    }
}
