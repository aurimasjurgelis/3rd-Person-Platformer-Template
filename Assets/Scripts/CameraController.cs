using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;

    public CinemachineBrain CMBrain;
    public CinemachineFreeLook CMFreelook;

    private void Awake()
    {
        instance = this;
    }
    void Update()
    {
        CMFreelook.m_XAxis.Value = SimpleInput.GetAxis("CameraHorizontal");
        CMFreelook.m_YAxis.Value = SimpleInput.GetAxis("CameraVertical");
    }
}
