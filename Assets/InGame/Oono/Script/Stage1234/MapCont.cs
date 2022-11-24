using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCont : MonoBehaviour
{
    GameObject player;
    PlayerHitPoint playerScript;

    Vector3 pos = new Vector3(0, 0, 0);

    public GameObject TestGroup;
    public GameObject Group1;
    public GameObject Group2;
    public GameObject Group3;
    public GameObject Group4;
    public GameObject Group5;
    public GameObject Group6;
    public GameObject Group7;
    public GameObject Group8;
    public GameObject GroupL;

    bool mapT = false;
    bool map1 = false;
    bool map2 = false;
    bool map3 = false;
    bool map4 = false;
    bool map5 = false;
    bool map6 = false;
    bool map7 = false;
    bool map8 = false;
    bool mapL = false;

    public bool tst = false;
    public bool ts1 = false;
    public bool ts2 = false;
    public bool ts3 = false;
    public bool ts4 = false;
    public bool ts5 = false;
    public bool ts6 = false;
    public bool ts7 = false;
    public bool ts8 = false;
    public bool tsL = false;

    public bool gc = false;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(TestGroup, pos, Quaternion.identity);

        player = GameObject.Find("Player");
        playerScript = player.GetComponent<PlayerHitPoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!mapT)
        {
            if (playerScript._fcount == 1)
            {
                mapT = true;
                tst = true;
                Instantiate(Group1, pos, Quaternion.identity);
            }
        }

        if (!map1)
        {
            if (playerScript._fcount == 2)
            {
                map1 = true;
                ts1 = true;
                Instantiate(Group2, pos, Quaternion.identity);
            }
        }
        if (!map2)
        {
            if (playerScript._fcount == 3)
            {
                map2 = true;
                ts2 = true;
                Instantiate(Group3, pos, Quaternion.identity);
            }
        }
        if (!map3)
        {
            if (playerScript._fcount == 4)
            {
                map3 = true;
                ts3 = true;
                Instantiate(Group4, pos, Quaternion.identity);
            }
        }
        if (!map4)
        {
            if (playerScript._fcount == 5)
            {
                map4 = true;
                ts4 = true;
                Instantiate(Group5, pos, Quaternion.identity);
            }
        }
        if (!map5)
        {
            if (playerScript._fcount == 6)
            {
                map5 = true;
                ts5 = true;
                Instantiate(Group6, pos, Quaternion.identity);
            }
        }
        if (!map6)
        {
            if (playerScript._fcount == 7)
            {
                map6 = true;
                ts6 = true;
                Instantiate(Group7, pos, Quaternion.identity);
            }
        }
        if (!map7)
        {
            if (playerScript._fcount == 8)
            {
                map7 = true;
                ts7 = true;
                Instantiate(Group8, pos, Quaternion.identity);
            }
        }
        if (!map8)
        {
            if (playerScript._fcount == 9)
            {
                map8 = true;
                ts8 = true;
                Instantiate(GroupL, pos, Quaternion.identity);
            }
        }
        if (!mapL)
        {
            if (playerScript._fcount == 10)
            {
                mapL = true;
                tsL = true;
                gc = true;
                //SceneManager.LoadScene("GC");
            }
        }
    }
}
