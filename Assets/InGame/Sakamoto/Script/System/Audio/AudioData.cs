using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "AudioData", menuName = "SakamotoScriptable/AudioData")]
public class AudioData : ScriptableObject
{
    public SoundPlayType Type;
    [Header("SoundのPrefab")]
    public GameObject SoundPrefab;
    [Header("Prefabの生成数")]
    public int MaxCount;
}
