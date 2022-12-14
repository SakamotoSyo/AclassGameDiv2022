using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIView : MonoBehaviour
{
    [Header("Timerを表示するUI")]
    [SerializeField] Text _timeText;

    public void SetTimer(float time) 
    {
        _timeText.text = time.ToString("0.0");
    }
}
