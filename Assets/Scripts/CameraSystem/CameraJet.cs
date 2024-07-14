using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Unity.VisualScripting;

public class CameraJet : CameraBase
{
    protected override void SetJoystickStartValue()
    {
        xValueJoystick = 0;
        yValueJoystick = .75f;
    }

    protected override void SetCameraSettings()
    {
        cam.m_Orbits[0].m_Height = -20; //bottom rig
        cam.m_Orbits[0].m_Radius = 10;
        cam.m_Orbits[1].m_Height = 25;  //middle rig
        cam.m_Orbits[1].m_Radius = 20;
        cam.m_Orbits[2].m_Height = 30;  //top rig
        cam.m_Orbits[2].m_Radius = 25;
    }
    
    protected override void IsVehicleAircraft()
    {
        if (isAircraft)
        {
            cam.m_Orbits[0].m_Height = 3; //bottom rig
            cam.m_Orbits[0].m_Radius = 10;
            cam.m_Orbits[1].m_Height = 25;  //middle rig
            cam.m_Orbits[1].m_Radius = 20;
            cam.m_Orbits[2].m_Height = 30;  //top rig
            cam.m_Orbits[2].m_Radius = 25;
        }
        else
        {
            SetCameraSettings();
        }
    }
    
}
