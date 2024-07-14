using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTank : CameraBase
{ 
    protected override void SetJoystickStartValue()
    {
        xValueJoystick = 0;
        yValueJoystick = .5f;
    }
    protected override void SetCameraSettings()
    {
        cam.m_Orbits[0].m_Height = 5; //bottom rig
        cam.m_Orbits[0].m_Radius = 15;
        cam.m_Orbits[1].m_Height = 10;  //middle rig
        cam.m_Orbits[1].m_Radius = 18;
        cam.m_Orbits[2].m_Height = 15;  //top rig
        cam.m_Orbits[2].m_Radius = 25;
    }
}
