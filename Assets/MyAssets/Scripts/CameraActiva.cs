using Cinemachine;
using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class CameraActiva : MonoBehaviour
{
    //[SerializeField] CinemachineVirtualCamera[] cameraActivas;
    [SerializeField] List<CinemachineVirtualCamera> cameraActivas;


    void Awake()
    {
        InitCamaras();
    }

    private void Start()
    {
        ActivarCamara(2);
    }
    void InitCamaras()
    {
        foreach (CinemachineVirtualCamera camera in cameraActivas)
        {
            camera.Priority = 10;
        }
    }


    void ActivarCamara(int activar)
    {
        string nombre = "Virtual Camera " + activar.ToString();
        //Debug.Log(nombre);

        InitCamaras();

        foreach (CinemachineVirtualCamera camera in cameraActivas)
        {
            if (camera.Name == nombre)
            {
                camera.Priority = 20;
                break;
            }
        }

    }


    void Update()
    {
        
    }


    public void SelectCameraClick(CinemachineVirtualCamera camera)
    {
        InitCamaras();
        camera.Priority = 20;
    }

}
