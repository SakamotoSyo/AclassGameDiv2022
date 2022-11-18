using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>ステージによって表示させる内容が変わるので、それを受け取って反映させる</summary>
public class GameStartTextManager : MonoBehaviour
{
    [Tooltip("WAVE数")] private int _wave = 0;
    [Tooltip("ステージのクリア条件")] private string _purpose = "じかんまで　いきのこれ！";
    [SerializeField, Header("WAVEを表示するテキスト")] private Text _waveText = default;
    [SerializeField, Header("クリア条件を表示するテキスト")] private Text _purposeText = default;

    void Start()
    {
        //wave数とクリア条件をどこかから受け取る
        //_wave = 
        //_purpose = 

        _waveText.text = $"WAVE{_wave.ToString()}";
        _purposeText.text = $"{_purpose}";
    }

}
