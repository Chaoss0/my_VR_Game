using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoringSystem : MonoBehaviour
{

    public TextMeshProUGUI textDisplay;
    public GameObject boss;
    public GameObject barage;
    public GameObject bitis;

    public GameObject bitmeKutlama;
    
    
    public static int theScore=10;
    public static int theHealth = 10;

    [SerializeField] private Animator soldakikapanma;
    [SerializeField] private string soldaki = "soldakikesn";
    [SerializeField] private Animator sagdakikapanma;
    [SerializeField] private string sagdaki = "allamsagdaki";











    void Start()
    {

        
        bitmeKutlama.SetActive(false);
        



    }

    void Update()
    {
        

        textDisplay.text = "Seytan HP: \n " + theScore + "/1000 HP \n"+" \n"+ "Your HP: \n " + theHealth + "\n" + "Time Left: \n ";
        




        if (theScore<=0)
        {
            
            
            endGame();
            return;
        }


    }


    void endGame()
    {
      
        
        boss.SetActive(false);
        
        
        barage.SetActive(false);
        bitis.SetActive(true);
        bitmeKutlama.SetActive(true);
        soldakikapanma.Play(soldaki, 0, 0f);
        sagdakikapanma.Play(sagdaki, 0, 0f);
        Debug.Log("besmele");
       





    }


}

//float timeLeft = 30.0f;  en üste bu
//timeLeft -= Time.deltaTime;
// textDisplay.text = "Seytan HP: \n " + theScore + "/1000 HP \n"+" \n"+ "Your HP: \n " + theHealth + "\n" + "Time Left: \n " + timeLeft+ "s"; <--- bu zaman da lazim olursa diye