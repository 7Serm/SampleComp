using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class CreatePbj : MonoBehaviour
{

    [SerializeField] private Transform[] CreatePoint;
    [SerializeField] private GameObject[] Gameobj;

    private int Randnum;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < CreatePoint.Length; i++)
        {
           Randnum =  Random.Range(0, 5);
            Instantiate(Gameobj[i], CreatePoint[Randnum]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
