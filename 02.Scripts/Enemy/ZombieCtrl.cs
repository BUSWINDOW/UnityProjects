using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//플레이어가 추적범위 안에 들어오면 추적
//공격범위 안에 들어오면 공격
[RequireComponent(typeof(NavMeshAgent))]
public class ZombieCtrl : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    private NavMeshAgent agent;
    public float traceDist;
    public float AttackDist;
    public Func<GameObject> PlayerSearchFunc;
    private const string isTrace = "isTrace";
    private const string isAttack = "isAttack";


    private readonly int hashAttack = Animator.StringToHash("isAttack");
    private readonly int hashTrace = Animator.StringToHash("isTrace");


    void Start()
    {
        this.animator = GetComponent<Animator>();
        this.agent = GetComponent<NavMeshAgent>();
        traceDist = 20f;
        AttackDist = 3f;
    }
    void Update()
    {
        if (Vector3.Distance(this.transform.position, this.PlayerSearchFunc().transform.position) < this.traceDist)
        {
            this.animator.SetBool(hashTrace, true);
            this.agent.SetDestination(this.PlayerSearchFunc().transform.position);
        }
        else
        {
            this.animator.SetBool(hashTrace, false);
            this.agent.ResetPath();
        }

        if (Vector3.Distance(this.transform.position, this.PlayerSearchFunc().transform.position) < this.AttackDist)
        {
            this.agent.ResetPath();
            this.animator.SetBool(hashAttack, true);
        }
        else
        {
            this.agent.SetDestination(this.PlayerSearchFunc().transform.position);
            this.animator.SetBool(hashAttack, false);
        }

    }
}
