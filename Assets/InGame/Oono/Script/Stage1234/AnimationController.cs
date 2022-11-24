using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    GameObject onoff;
    OnOffController onOffController;

    GameObject player;
    PlayerHitPoint playerHitPoint;

    // Start is called before the first frame update
    void Start()
    {
        onoff = GameObject.Find("OnOffController");
        onOffController = onoff.GetComponent<OnOffController>();

        player = GameObject.Find("Player");
        playerHitPoint = player.GetComponent<PlayerHitPoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onOffController._gameo)
        {
            Invoke("ActiveF", 0.5f);
        }

    }

    void ActiveF()
    {
        player.gameObject.SetActive(false);
    }
}
