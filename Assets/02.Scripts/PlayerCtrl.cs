using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // -1.0f ~ 0.0f ~ +1.0f
        float v = Input.GetAxis("Vertical");   // -1.0f ~ 0.0f ~ +1.0f

        Debug.Log("h=" + h);
        Debug.Log("v=" + v);

        //transform.position += new Vector3(0, 0, 0.1f);
        transform.Translate(Vector3.forward * v * 0.1f); 
        transform.Translate(Vector3.right * h * 0.1f);

        /* 
            정규화벡터(Normalized vector), 단위벡터(Unit Vector)
            Vector3.forward = Vector3(0,0,1)
            Vector3.up      = Vector3(0,1,0)
            Vector3.right   = Vector3(1,0,0)

            Vector3.one     = Vector3(1,1,1)
            Vector3.zero    = Vector3(0,0,0)
        */

    }
}
