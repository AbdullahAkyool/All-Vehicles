using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHelicopter : CameraBase
{
    
    protected override void SetJoystickStartValue()
    {
        xValueJoystick = 0;
        yValueJoystick = .5f;
    }
    protected override void SetCameraSettings()
    {
        cam.m_Orbits[0].m_Height = -15; //bottom rig
        cam.m_Orbits[0].m_Radius = 7;
        cam.m_Orbits[1].m_Height = 5; //middle rig
        cam.m_Orbits[1].m_Radius = 14;
        cam.m_Orbits[2].m_Height = 20; //top rig
        cam.m_Orbits[2].m_Radius = 25;
    }

    protected override void IsVehicleAircraft()
    {
        if (isAircraft)
        {
            cam.m_Orbits[0].m_Height = 3; //bottom rig
            cam.m_Orbits[0].m_Radius = 10;
            cam.m_Orbits[1].m_Height = 5; //middle rig
            cam.m_Orbits[1].m_Radius = 14;
            cam.m_Orbits[2].m_Height = 20; //top rig
            cam.m_Orbits[2].m_Radius = 25;
        }
        else
        {
            SetCameraSettings();
        }
    }
}