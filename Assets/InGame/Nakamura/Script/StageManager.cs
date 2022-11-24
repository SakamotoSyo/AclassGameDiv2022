using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : MonoBehaviour
{
    [SerializeField, Header("clear‚Ü‚Å‚ÌŽžŠÔ")]
    private float _limitTime = 25f;
    float _nowTime;
    Text _text;

    private void Start()
    {
        _nowTime = _limitTime;
        _text = GameObject.Find("Time").GetComponent<Text>();
    }

    private void Update()
    {
        _nowTime -= Time.deltaTime;
        if (_nowTime <= 0)
        {
            GameManager.StageEnd(true);
        }
        _text.text = _nowTime.ToString("00");
    }
}
