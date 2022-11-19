using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Events;

/// <summary>Timeline���I������玟�̃V�[���ɍs��</summary>
public class TimelineObserver : MonoBehaviour
{
    [Tooltip("Timeline�̃R���|�[�l���g")] private PlayableDirector _playableDirector = default;
    [Tooltip("Timeline���I�����Ă��邩�ǂ���")] public bool IsDone() { return _playableDirector.time >= _playableDirector.duration; }
    [Tooltip("��񂾂��Ăяo���悤�Ɉꉞ")] private bool _isDone = false;

    void Start()
    {
        _playableDirector = GetComponent<PlayableDirector>();
    }

    void Update()
    {
        
        //Timeline���Đ����I������A�Q�[���V�[���Ɉړ�����
        if(IsDone() && !_isDone)
        {
            _isDone = true;
            GameManager.NextScene();
        }

    }
}
