using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveilergeri : MonoBehaviour
{
    public float delta = 2f;  // Amount to move left and right from the start point
    public float speed = 4f; 
    private Vector3 startPos;
    
    void Start () {
        
        startPos = transform.position;
 
    }
     
    void Update () {


        if(ScoringSystem.theScore >= 300)
        {
            if(ScoringSystem.theScore <=800)
            {
                lvlMiddle();
                
            }

        }


        if(ScoringSystem.theScore >= 800)
        {
            lvlEasy();
            
        }
    }



    void lvlEasy()
    {
        Vector3 v = startPos;
        v.z += 7 * Mathf.Sin (Time.time * 1f);
        transform.position = v;
    }

    void lvlMiddle()
    {
        Vector3 v = startPos;
        v.z += 7 * Mathf.Sin (Time.time * 1.5f);
        transform.position = v;
    }

    void lvlHard()
    {
        Vector3 v = startPos;
        v.z += 7 * Mathf.Sin (Time.time * 2f);
        transform.position = v;
    }

}
