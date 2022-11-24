using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cikisdoor : MonoBehaviour
{

    [SerializeField] private Animator sagkapi=null;
    [SerializeField] private Animator solkapi=null;
    [SerializeField] private bool closeTrigger=false;
    [SerializeField] private string sagbitti="sagbitti";
    [SerializeField] private string solbitti="solbitti";


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            if(closeTrigger)
            {
                sagkapi.Play("sagbitti",0,0.0f);
                solkapi.Play("solbitti",0,0.0f);
                gameObject.SetActive(false);
            }
        }        
    }
}