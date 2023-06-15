using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punishment : MonoBehaviour
{
    [Tooltip("罰として床を消すための変数")]
    [SerializeField] GameObject Plane;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Plane.SetActive(false);
        }
    }
}
