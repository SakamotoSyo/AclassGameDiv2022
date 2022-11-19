using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Events;

/// <summary>Timelineが終わったら次のシーンに行く</summary>
public class TimelineObserver : MonoBehaviour
{
    private PlayableDirector _playableDirector = default;
    public bool IsDone() { return _playableDirector.time >= _playableDirector.duration; }
    [SerializeField, Header("Timelineが終わったら呼び出されるイベント")] UnityEvent _endTimeline = default;
    private bool _isDone = false;

    void Start()
    {
        _playableDirector = GetComponent<PlayableDirector>();
    }

    void Update()
    {
        
        if(IsDone() && !_isDone)
        {
            _isDone = true;
            _endTimeline.Invoke();
        }

    }
}
