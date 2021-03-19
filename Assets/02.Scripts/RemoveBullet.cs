using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{

    //충돌 콜백함수
    void OnCollisionEnter(Collision coll)
    {
        //if (coll.collider.tag == "BULLET") //coll.gameObject.tag == "BULLET"

        if (coll.collider.CompareTag("BULLET")) //GC 발생하지 않는다.
        {
            Debug.Log($"Object = {coll.collider.name}");
            Destroy(coll.gameObject);
        }
    }
}
