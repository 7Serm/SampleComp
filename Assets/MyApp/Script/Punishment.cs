using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punishment : MonoBehaviour
{
    [Tooltip("”±‚Æ‚µ‚Ä°‚ğÁ‚·‚½‚ß‚Ì•Ï”")]
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
