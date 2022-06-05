using System;
using System.Collections;
using System.Collections.Generic;
using JoyConUnity;
using UnityEngine;
using UnityEngine.UI;

public class JoyConBehaviour : MonoBehaviour
{
    private const float DragScale = 65f;
    
    public bool IsLeft;
    public Toggle Top;
    public Toggle TopZ;
    public Toggle SL;
    public Toggle SR;
    public Toggle Stick;
    public Toggle Up;
    public Toggle Left;
    public Toggle Down;
    public Toggle Right;
    public Toggle Plus;
    public Toggle Home;
    public Image StickKnob;
    private JoyCon JoyCon
    {
        get
        {
            if (JoyConManager.Instance == null) return null;
            return IsLeft ? JoyConManager.Instance.LeftController : JoyConManager.Instance.RightController;
        }
    }
    private void Update()
    {
        if (JoyCon == null) return;

        Top.isOn = JoyCon.GetButton(JoyCon.Button.SHOULDER_1);
        TopZ.isOn = JoyCon.GetButton(JoyCon.Button.SHOULDER_2);
        SL.isOn = JoyCon.GetButton(JoyCon.Button.SL);
        SR.isOn = JoyCon.GetButton(JoyCon.Button.SR);
        Stick.isOn = JoyCon.GetButton(JoyCon.Button.STICK);
        Up.isOn = JoyCon.GetButton(JoyCon.Button.DPAD_UP);
        Left.isOn = JoyCon.GetButton(JoyCon.Button.DPAD_LEFT);
        Down.isOn = JoyCon.GetButton(JoyCon.Button.DPAD_DOWN);
        Right.isOn = JoyCon.GetButton(JoyCon.Button.DPAD_RIGHT);
        Plus.isOn = JoyCon.GetButton(IsLeft ? JoyCon.Button.MINUS : JoyCon.Button.PLUS);
        Home.isOn = JoyCon.GetButton(IsLeft ? JoyCon.Button.CAPTURE : JoyCon.Button.HOME);

        StickKnob.transform.localPosition = JoyCon.GetStick() * DragScale;
    }
}
