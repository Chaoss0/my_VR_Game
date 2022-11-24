using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silahtaslari : MonoBehaviour
{
    public AudioSource insanadegme;

    void Start()
    {

    }
    void OnCollisionEnter(Collision collision)
    {


    }
    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "delay")//delay(görünmez duvar) adli yere girdiginde
        {

            Debug.Log("ok");//ok yaz(calisiyo mu deneme amacli kaldirilabilir)
            Destroy(gameObject, 4.0f);// 4 saniye sonra yok et

        }

        if (collision.gameObject.tag == "Player")//Player adli yere girdiginde
        {

            Debug.Log("ok");
            ScoringSystem.theHealth -= 100;// canin 100 azalmasi
            insanadegme.Play();
            Destroy(gameObject);// tasin yok olmasi

        }
    }

}
