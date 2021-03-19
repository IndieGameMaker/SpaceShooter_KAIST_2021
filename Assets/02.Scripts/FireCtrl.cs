using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //총알을 동적으로 생성
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }        
    }
}
