using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitPoint : MonoBehaviour
{
    public int _count;
    public int _hcount;
    public int _fcount;
    public bool _gameOver;
    public bool _gameClear;

    GameObject _onoff;
    OnOffController _onOffController;

    // Start is called before the first frame update
    void Start()
    {
        _count = 0;
        _hcount = 0;
        _fcount = 0;
        _gameOver = false;
        _gameClear = false;

        _onoff = GameObject.Find("OnOffController");
        _onOffController = _onoff.GetComponent<OnOffController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_hcount >= 1)
        {
            _onOffController._p = _onOffController._p + 1;
            _hcount = 0;
        }

        if(_count >= 3)
        {
            _gameOver = true;
        }

        if (_fcount >= 1)
        {
            Debug.Log("Clear");
            _gameClear = true;
        }
    }
 }
