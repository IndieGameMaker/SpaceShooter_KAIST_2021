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
            //총알을 동적으로 생성
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
            // audio.clip = fireSfx;
            // audio.Play();
            audio.PlayOneShot(fireSfx, 0.5f);
        }        
    }
}
