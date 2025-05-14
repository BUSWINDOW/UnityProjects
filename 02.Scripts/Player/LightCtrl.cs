using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�÷��̾ ������ �����Ǹ� ���� Ű��
//�������� ���������� ���� ��

public class LightCtrl : MonoBehaviour
{
    private Light _light;
    private const string player = "Player";
    private AudioSource source;
    [SerializeField]
    private AudioClip clip;

    void Start()
    {
        _light = GetComponentInChildren<Light>();
        this._light.enabled = false;
        this.source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == player)
        {
            StopAllCoroutines();
            this._light.enabled = true;
            this.source.PlayOneShot(this.clip);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == player)
        {
            StartCoroutine(this.LightOffRoutine());
        }
    }
    IEnumerator LightOffRoutine()
    {
        yield return new WaitForSeconds(3);
        this._light.enabled = false;
        this.source.PlayOneShot(this.clip);
    }
}
