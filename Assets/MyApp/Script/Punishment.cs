using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punishment : MonoBehaviour
{
    [Tooltip("���Ƃ��ď����������߂̕ϐ�")]
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
