using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    GameObject player; 
    PlayerHitPoint playerHitPoint;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerHitPoint = player.GetComponent<PlayerHitPoint>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(this.gameObject.name =="Flag")
        {
            if (collision.gameObject.name == "Player")
            {
                playerHitPoint._fcount = playerHitPoint._fcount + 1;
                playerHitPoint._hcount = playerHitPoint._hcount + 1;
                Destroy(this.gameObject);
            }
        }
        else
        {
            if (collision.gameObject.name == "Player")
            {
                playerHitPoint._count = playerHitPoint._count + 1;
                playerHitPoint._hcount = playerHitPoint._hcount + 1;
                Destroy(this.gameObject);
            }
        }
    }
}
