using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]
    GameObject cameraPoint1;
    [SerializeField]
    GameObject cameraPoint2;
    [SerializeField]
    GameObject cameraPoint3;
    [SerializeField]
    GameObject cameraPoint4;
    [SerializeField]
    Light[] lights;

    private Transform camera;

    private void Start()
    {
        camera = Camera.main.transform;
    }

    public void OnCam1Click()
    {
        camera.transform.position = cameraPoint1.transform.position;
        camera.transform.rotation = cameraPoint1.transform.rotation;
    }

    public void OnCam2Click()
    {
        camera.transform.position = cameraPoint2.transform.position;
        camera.transform.rotation = cameraPoint2.transform.rotation;
    }

    public void OnCam3Click()
    {
        camera.transform.position = cameraPoint3.transform.position;
        camera.transform.rotation = cameraPoint3.transform.rotation;
    }

    public void OnCam4Click()
    {
        camera.transform.position = cameraPoint4.transform.position;
        camera.transform.rotation = cameraPoint4.transform.rotation;
    }

    public void OnReverseLightClick()
    {
        foreach (var l in lights)
            l.gameObject.SetActive(!l.gameObject.activeSelf);
    }

    public void OnLamp1ValueChange(float val)
    {
        lights[0].intensity = val;
    }

    public void OnLamp2ValueChange(float val)
    {
        lights[1].intensity = val;
    }

    public void OnLamp3ValueChange(float val)
    {
        lights[2].intensity = val;
    }

    public void OnLamp4ValueChange(float val)
    {
        lights[3].intensity = val;
    }

    public void OnLamp5ValueChange(float val)
    {
        // table lamp changes
        lights[4].intensity = val;
        lights[5].intensity = val;
    }
}
