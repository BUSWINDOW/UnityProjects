using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject Enemy;
    public GameObject SKel;
    void Start()
    {
        this.Enemy.GetComponent<ZombieCtrl>().PlayerSearchFunc += () =>
        {
            return this.player;
        };
        this.SKel.GetComponent<ZombieCtrl>().PlayerSearchFunc += () =>
        {
            return this.player;
        };
    }
    void Update()
    {
        
    }
}
