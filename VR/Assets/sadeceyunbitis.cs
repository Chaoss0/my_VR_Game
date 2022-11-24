using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sadeceyunbitis : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (ScoringSystem.theScore <= 0)
        {


            endGame();
        }

    }

    void endGame()
    {
        

    }
}
