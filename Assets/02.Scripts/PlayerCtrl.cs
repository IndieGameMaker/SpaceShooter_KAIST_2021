using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField]
    private Transform tr;
    private Animation anim;

    public float moveSpeed = 10.0f;
    public float turnSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        anim = GetComponent<Animation>();
        anim.Play("Idle");
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // -1.0f ~ 0.0f ~ +1.0f
        float v = Input.GetAxis("Vertical");   // -1.0f ~ 0.0f ~ +1.0f
        float r = Input.GetAxis("Mouse X");

        //Debug.Log("h=" + h + " v=" + v); //Debug.LogFormat()
        //Debug.Log($"h={h} v={v}");  //문자열 치환
        
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
        tr.Translate(moveDir.normalized * Time.deltaTime * moveSpeed);
        tr.Rotate(Vector3.up * Time.deltaTime * r * turnSpeed);

        if (v >= 0.1f)
        {
            //전진 애니메이션 클립으로 변환
            anim.CrossFade("RunF", 0.25f);
        }
        else if (v <= -0.1f)
        {
            //후진
            anim.CrossFade("RunB", 0.25f);
        }
        else if (h >= 0.1f) //오른쪽 이동
        {
            anim.CrossFade("RunR", 0.25f);
        }
        else if (h <= -0.1f)
        {
            
        }

    }
}
