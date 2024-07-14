using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCar : CameraBase
{
    protected override void SetJoystickStartValue()
    {
        xValueJoystick = 0;
        yValueJoystick = 1f;
    }
    protected override void SetCameraSettings()
    {
        cam.m_Orbits[0].m_Height = 2; //bottom rig
        cam.m_Orbits[0].m_Radius = 8;
        cam.m_Orbits[1].m_Height = 8;  //middle rig
        cam.m_Orbits[1].m_Radius = 12;
        cam.m_Orbits[2].m_Height = 12;  //top rig
        cam.m_Orbits[2].m_Radius = 18;
    }
}
