using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBack : MonoBehaviour
{
    private GameObject Player;

    Vector3 pos0 = new Vector3(0f, 0f, 9f);
    Vector3 pos1 = new Vector3(5f, 0f, -7f);
    Vector3 pos2 = new Vector3(-3f, 0f, -5f);

    public Vector3 TriVec0;
    public Vector3 TriVec1;
    public Vector3 TriVec2;

    public float Cross0;
    public float Cross1;
    public float Cross2;

    public bool Hit = false;

    public Vector3 memo;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");

        TriVec0 = (pos1 - pos0).normalized;
        TriVec1 = (pos2 - pos1).normalized;
        TriVec2 = (pos0 - pos2).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerpos = Player.transform.position;

        Vector3 HitVec0 = playerpos - pos0;
        Vector3 HItVec1 = playerpos - pos1;
        Vector3 HitVec2 = playerpos - pos2;

        Cross0 = TriVec0.z * HitVec0.x - TriVec0.x * HitVec0.z;
        Cross0 = TriVec1.z * HItVec1.x - TriVec1.x * HItVec1.z;
        Cross0 = TriVec2.z * HitVec2.x - TriVec2.x * HitVec2.z;

        if(Cross1 >= 0f)
        {
            if((Cross1 >= 0f) && (Cross2 >= 0f))
            {
                transform.position = memo;
            }
            else
            {
                memo = playerpos;
            }

        }
        else
        {
            if((Cross1 < 0f ) && (Cross2 < 0f))
            {
                transform.position = memo;
            }

            else
            {
                memo = playerpos;
            }
        }
    }
}
