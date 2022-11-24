using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    Vector3 _upos;
    Vector3 _dpos;

    // Start is called before the first frame update
    void Start()
    {
        _upos = new Vector3(0, 0, -1);
        _dpos = new Vector3(0, 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Up()
    {
        gameObject.transform.position = _upos;
    }

    public void Down()
    {
        gameObject.transform.position = _dpos;
    }
}
