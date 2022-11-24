using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class Hand : MonoBehaviour
{
    ActionBasaedController controller;
    public Hand hand;
    // Start is called before the first frame update
    void Start()
    {
        controller=GetComponent<ActionBasaedController>();

    }

    // Update is called once per frame
    void Update()
    {
        hand.SetGrip(controller.selectAction.Action.ReadValue<float>());
        hand.SetTrigger(controller.selectAction.Action.ReadValue<float>());

        
    }
}
