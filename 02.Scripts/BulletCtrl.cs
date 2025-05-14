using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//스스로 Z축으로 발사됨
public class BulletCtrl : MonoBehaviour
{
    public float speed = 1500f;
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.Impulse);
    }

}
