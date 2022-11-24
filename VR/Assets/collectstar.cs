using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Random = System.Random;

public class collectstar : MonoBehaviour
{
    [SerializeField] Transform Gun;
    [SerializeField] GameObject Bullets;
    public AudioSource seytanvurulma;






    void Start()
    {



    }

    void Update()
    {

    }
    void OnCollisionEnter (Collision collision) 
    {
        
        if (collision.gameObject.tag == "seytan")//seytan tagli bir collisiona degerse
        {
            Random rnd = new Random();// random sayi ügretmek icin gereken sey  
            int rand_num  = rnd.Next(50, 100);//50 ile 100 arasinda random sayi
            
            

            ScoringSystem.theScore-=rand_num;// canin azalmasi
            seytanvurulma.Play();
            
            Destroy(gameObject);// taasin yok olmasi
        }









    }  

    void OnTriggerEnter(Collider collision) {

        if (collision.gameObject.tag == "delay")//delay(görünmez duvar) adli yere girdiginde
        {
            
            Debug.Log("ok");//ok yaz(calisiyo mu deneme amacli kaldirilabilir)
            Destroy(gameObject, 4.0f);// 4 saniye sonra yok et
            GameObject Bullet = Instantiate(Bullets, Gun.gameObject.transform.position, Gun.gameObject.transform.rotation) as GameObject;//eski yerinde yenisini olustur
            
        }

    }   
    

    
}

