using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    GameObject player; 
    PlayerHitPoint playerHitPoint;

    int _i;
    int _t;
    int _c;

    public AudioClip sec;
    AudioSource audioSourceC;
    public AudioClip seb;
    AudioSource audioSourceB;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerHitPoint = player.GetComponent<PlayerHitPoint>();

        _i = 0;
        _t = 0;
        _c = 0;

        audioSourceC = GetComponent<AudioSource>();
        audioSourceB = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_i == 0)
        { 
            if (this.gameObject.name == "Flag")
            {
                _t = 1;
                _i = 1;
            }
            else
            {
                _c = 1;
                _i = 1;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_c == 1)
        {
            if (collision.gameObject.name == "Player")
            {
                AudioSource.PlayClipAtPoint(seb, transform.position);
                playerHitPoint._count = playerHitPoint._count + 1;
                playerHitPoint._hcount = playerHitPoint._hcount + 1;
                Destroy(this.gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_t == 1)
        {
            if (collision.gameObject.name == "Player")
            {
                AudioSource.PlayClipAtPoint(sec, transform.position);
                playerHitPoint._fcount = playerHitPoint._fcount + 1;
                playerHitPoint._hcount = playerHitPoint._hcount + 1;
                Destroy(this.gameObject);
            }
        }
    }
}
