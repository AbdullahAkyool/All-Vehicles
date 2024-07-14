using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Unity.VisualScripting;

public abstract class CameraBase : MonoBehaviour
{
    public CinemachineFreeLook cam;
    public FloatingJoystick joystick;

    public float xValueJoystick;
    public float yValueJoystick;
    [SerializeField] private float dragSpeedX = -100;
    [SerializeField] private float dragSpeedY = -1;

    public bool isAircraft;

    public float XValueJoystick
    {
        get { return xValueJoystick; }
        set { xValueJoystick = value; }
    }

    public float YValueJoystick
    {
        get { return yValueJoystick; }
        set { yValueJoystick = Mathf.Clamp(value, 0, 1); }
    }

    public void Start()
    {
        SetJoystickStartValue();
        
        SetCameraSettings();
    }

    void Update()
    {
        CameraMovement();
        IsVehicleAircraft();
    }

    void CameraMovement()
    {
        XValueJoystick += joystick.input.x * Time.deltaTime * dragSpeedX;
        YValueJoystick += joystick.input.y * Time.deltaTime * dragSpeedY;

        cam.m_XAxis.Value = XValueJoystick;
        cam.m_YAxis.Value = YValueJoystick;
    }

    protected abstract void SetCameraSettings();

    protected virtual void IsVehicleAircraft() {}

    protected virtual void SetJoystickStartValue()
    {
        xValueJoystick = 0;
        yValueJoystick = 0f;
    }
}