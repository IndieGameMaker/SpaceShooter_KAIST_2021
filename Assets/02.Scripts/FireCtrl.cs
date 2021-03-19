using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class FireCtrl : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePos;
    public AudioClip fireSfx;

    private new AudioSource audio;
    [SerializeField]
    private MeshRenderer muzzleFlash;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        muzzleFlash = firePos.GetComponentInChildren<MeshRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }        
    }

    void Fire()
    {
        //총알을 동적으로 생성
        Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        audio.PlayOneShot(fireSfx, 0.5f);

        //MuzzleFlash 회전
        //난수발생
        /*
            Random.Range(0, 10)  0,..9
            Random.Range(0.0f, 10.0f) 0.0f ~ 10.0f
        */
        float angle = Random.Range(0.0f, 360.0f); //오일러각
        muzzleFlash.transform.localRotation = Quaternion.Euler(0, 0, angle);// Quaternion.Euler(Vector3.forward * angle);
        float scale = Random.Range(1.0f, 3.0f);
        muzzleFlash.transform.localScale = Vector3.one * scale; //new Vector3(scale, scale, scale);
    }
}
