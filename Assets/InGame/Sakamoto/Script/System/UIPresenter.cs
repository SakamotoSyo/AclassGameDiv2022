using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class UIPresenter : MonoBehaviour
{
    [Header("‚±‚ÌScene‚ÌUI‚ðŠÇ—‚·‚é")]
    [SerializeField] UIView _uiView;
    [Header("Time‚ðŒv‘ª‚µ‚Ä‚¢‚éScript(Model)")]
    [SerializeField] TutorialStageClearJudge _clearJudge;

    void Start()
    {
        _clearJudge.TimeChanged.Subscribe(value => _uiView.SetTimer(value));
    }
}
