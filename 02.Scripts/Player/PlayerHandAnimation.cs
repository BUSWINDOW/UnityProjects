using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
//달리기 시작 : 총을 접음
//달리는 중 : 총을 접고있음
//달리기 끝 : 총을 다시 겨눔
public class PlayerHandAnimation : MonoBehaviour
{
    [SerializeField]
    private Animation animation;
    private bool isRunning;
    private bool isRunning2; // isRunning 조건이 업데이트에서 한번만 걸리게
    void Start()
    {
        this.animation = this.transform.GetChild(0).GetChild(0).GetComponent<Animation>();
        //this.animation = GetComponentInChildren<Animation>();
        this.isRunning = false;
        this.isRunning2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            this.animation.CrossFade("runStart",0.2f);
            this.animation.CrossFade("running", 0.2f);
            this.isRunning = true;
            //StartCoroutine(RunRoutine());
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.W))
        {
            this.animation.Play("runStop");
            this.isRunning = false;
        }
        /*if (isRunning)
        {
            if (!isRunning2)
            {
                this.animation.CrossFade("running", 0.2f);
                this.isRunning2 = true;
            }
            
        }*/
        if (Input.GetButtonDown("Fire1")  && !isRunning)
        {
            this.animation.Play("fire");
        }
    }

    IEnumerator RunRoutine()
    {
        //if (isRunning) yield break;
        yield return new WaitForSeconds(0.5f);
        this.isRunning = true;
    }
}
