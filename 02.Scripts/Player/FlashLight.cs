using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//FŰ�� ������ ���� �����鼭 �Ҹ���


public class FlashLight : MonoBehaviour
{
    [SerializeField]
    private Light flashLight;

    private AudioSource source;
    public AudioClip clip;
    void Start()
    {
        this.flashLight = GetComponent<Light>();
        this.source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            LightSwitch();
        }
        /*else if (Input.GetKeyUp(KeyCode.F))
        {
            LightSwitch();

        }*/
    }

    private void LightSwitch()
    {
        this.flashLight.enabled = !this.flashLight.enabled;
        this.source.PlayOneShot(this.clip);
    }
}
