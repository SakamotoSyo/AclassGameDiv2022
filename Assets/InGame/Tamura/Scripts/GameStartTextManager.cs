using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>ステージによって表示させる内容が変わるので、それを受け取って反映させる</summary>
public class GameStartTextManager : MonoBehaviour
{
    [Tooltip("WAVE数")] private int _wave = 0;
    [Tooltip("ステージのクリア条件")] private string[] _purpose = 
        { "じかんまで　いきのこれ！" , "stage2の目標"};
    [SerializeField, Header("WAVEを表示するテキスト")] private Text _waveText = default;
    [SerializeField, Header("クリア条件を表示するテキスト")] private Text _purposeText = default;

    void Start()
    {
        //wave数を受け取って、wave数と対応した目標を表示
        _wave = GameManager.GetStageNum;
        _waveText.text = $"WAVE{_wave.ToString()}";
        _purposeText.text = $"{_purpose[_wave - 1]}";
    }

}
