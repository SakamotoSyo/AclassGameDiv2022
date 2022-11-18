using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>�X�e�[�W�ɂ���ĕ\����������e���ς��̂ŁA������󂯎���Ĕ��f������</summary>
public class GameStartTextManager : MonoBehaviour
{
    [Tooltip("WAVE��")] private int _wave = 0;
    [Tooltip("�X�e�[�W�̃N���A����")] private string _purpose = "������܂Ł@�����̂���I";
    [SerializeField, Header("WAVE��\������e�L�X�g")] private Text _waveText = default;
    [SerializeField, Header("�N���A������\������e�L�X�g")] private Text _purposeText = default;

    void Start()
    {
        //wave���ƃN���A�������ǂ�������󂯎��
        //_wave = 
        //_purpose = 

        _waveText.text = $"WAVE{_wave.ToString()}";
        _purposeText.text = $"{_purpose}";
    }

}
