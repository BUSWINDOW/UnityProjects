using System.Collections;
using System.Collections.Generic;
using DigitalRuby.RainMaker;
using UnityEngine;

public class RainStopCtrl : MonoBehaviour
{
    private const string player = "Player";
    public RainScript rain;
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == player)
        {
            this.rain.RainIntensity = 0;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == player)
        {
            this.rain.RainIntensity = 1;
        }
    }
}
