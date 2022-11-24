using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    public AudioSource closingaudio;
    public AudioSource pisseytan;
    public GameObject silah;


    [SerializeField] private Animator myDoorLeft=null;
    [SerializeField] private Animator myDoorRight=null;
    [SerializeField] private bool closeTrigger=false;

    [SerializeField] private string closedoor="doorclose";
    [SerializeField] private string doorclose="closedoor";
     



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(closeTrigger)
            {
                myDoorLeft.Play("doorclose",0,0.0f);
                myDoorRight.Play("closedoor",0,0.0f);
                closingaudio.Play();
                pisseytan.Play();
                gameObject.SetActive(false);
                silah.SetActive(true);

            }

        }
    }

}
