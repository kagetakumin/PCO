using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DefineConstant;

public class InputManager : ASingletonMonoBehavior<InputManager>
{
    InputState cursorState;
    Vector3 cursorPosition;

    private void Update()
    {
        if(Input.mousePresent) cursorPosition = Input.mousePosition;
        if(Input.GetButtonDown("Fire1"))
        {

        }
    }
}
