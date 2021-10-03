using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PickUpItem : MonoBehaviour
{
    private ActionBasedController controller;

    void Start() 
    {
        controller = GetComponent<ActionBasedController>();  

        // //old way
        // bool isPressed = controller.selectAction.action.ReadValue<bool>();

        //New way
        controller.selectAction.action.performed += middleFingerPress;
    }


    private void middleFingerPress(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        
    }
    private void analogStick(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
