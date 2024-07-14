using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDestroyer : CameraBase
{
    protected override void SetJoystickStartValue()
    {
        xValueJoystick = 0;
        yValueJoystick = .5f;
    }
    protected override void SetCameraSettings()
    {
        cam.m_Orbits[0].m_Height = 10; //bottom rig
        cam.m_Orbits[0].m_Radius = 33;
        cam.m_Orbits[1].m_Height = 17;  //middle rig
        cam.m_Orbits[1].m_Radius = 38;
        cam.m_Orbits[2].m_Height = 24;  //top rig
        cam.m_Orbits[2].m_Radius = 43;
    }
}
