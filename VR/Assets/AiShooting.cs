using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AiShooting : MonoBehaviour
{
    public AudioSource aslan;
    [Header("GameObjects")]
    [SerializeField] GameObject player;
    [SerializeField] GameObject Bullets;

    [Header("Distance Between Player")]
    [SerializeField] float MaxDis = 0f;
    [SerializeField] float MinDis = 100f;
    float DisBtw;

    [Header("Enemy Constraints")]
    [SerializeField] float DestroyTime = 3f;
    [SerializeField] Transform Gun;
 
    [Header("Bullet Constraints")]
    [SerializeField] float BulletLifeTime = 5f;
    [SerializeField] float TimeBtwShots = 3f;
    bool IsShoot = true;

    void Start()
    {
        //caching a reference to the player.
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {

        


        
        //call the function for pointing gun towards the player.
        if(IsShoot && DisBtw <= MinDis)
        {
            //then start firing the gun.
            StartCoroutine(Fire());
        }
        
        
        
        //if all the condition for shooting is true and the enemy is in shooting range.

    }
    




    //the function call for firing the bullet.
    IEnumerator Fire()
    {   
        //instantiate the bullet as gameobject 

        GameObject Bullet = Instantiate(Bullets, Gun.gameObject.transform.position, Gun.gameObject.transform.rotation) as GameObject; //shoots from enemies eyes
        Rigidbody RigidBodyBullet = Bullet.GetComponent<Rigidbody>();
        RigidBodyBullet.AddForce(RigidBodyBullet.transform.forward * 5);
        aslan.Play();// fire sound

        //wait until the time between shots to complete and fire again.
        IsShoot = false;
        //GameObject Bullet = Instantiate(Bullets,Gun.position,Gun.rotation,Gun.transform) as GameObject;
        Destroy(Bullet, BulletLifeTime);
        yield return new WaitForSeconds(TimeBtwShots);
        IsShoot = true;
    }


}
