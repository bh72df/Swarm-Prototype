using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    [HideInInspector] public Vector2 move;
    [HideInInspector] public bool fire;
    [HideInInspector] public bool jump;
    [HideInInspector] public bool sprint;

    public void OnMove (InputValue value) => move = value.Get<Vector2>();
    public void OnFire(InputValue value) => fire = Convert.ToBoolean( value.Get<float>());
    public void OnJump(InputValue value) => jump = Convert.ToBoolean(value.Get<float>());
    public void OnSprint(InputValue value) => sprint = Convert.ToBoolean(value.Get<float>());
 






}
