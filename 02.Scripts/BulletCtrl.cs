using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//������ Z������ �߻��
public class BulletCtrl : MonoBehaviour
{
    public float speed = 1500f;
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.Impulse);
    }

}
