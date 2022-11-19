using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Events;

/// <summary>Timelineが終わったら次のシーンに行く</summary>
public class TimelineObserver : MonoBehaviour
{
    [Tooltip("Timelineのコンポーネント")] private PlayableDirector _playableDirector = default;
    [Tooltip("Timelineが終了しているかどうか")] public bool IsDone() { return _playableDirector.time >= _playableDirector.duration; }
    [Tooltip("一回だけ呼び出すように一応")] private bool _isDone = false;

    void Start()
    {
        _playableDirector = GetComponent<PlayableDirector>();
    }

    void Update()
    {
        
        //Timelineを再生し終えたら、ゲームシーンに移動する
        if(IsDone() && !_isDone)
        {
            _isDone = true;
            GameManager.NextScene();
        }

    }
}
