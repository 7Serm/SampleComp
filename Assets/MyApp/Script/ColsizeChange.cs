using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColsizeChange : MonoBehaviour
{

    private CapsuleCollider Col;

    [SerializeField] private int y;

    private Vector3 v3;
    // Start is called before the first frame update
    void Start()
    {
        Col = GetComponent<CapsuleCollider>();
        
    }

    // Update is called once per frame
    void Update()
    {
       v3 = new Vector3(0,y,0);

        Col.center = v3;
    }
}
