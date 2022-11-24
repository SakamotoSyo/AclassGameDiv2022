using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffController : MonoBehaviour
{
    GameObject _light;
    LightsController lightsController;

    public int _p;
    int _i;

    // Start is called before the first frame update
    void Start()
    {
        _light = GameObject.Find("Lights");
        lightsController = _light.GetComponent<LightsController>();

        _p = 0;
        _i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(_i == 0)
        {
            Invoke("Lon", 3.0f);
            _i = _i + 1;
        }

        if(_p >= 1)
        {
            Loff();
            _p = 0;
        }
    }

    void Lon()
    {
        lightsController.Up();
    }

    void Loff()
    {
        lightsController.Down();
        Invoke("Lon", 3.0f);
    }
}
