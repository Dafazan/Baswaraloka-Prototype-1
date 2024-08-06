using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSettingsUI : MonoBehaviour
{

    FirstPersonController fpscont;
    public float ZoomAmt;
    // Start is called before the first frame update
    void Start()
    {
        fpscont = GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        fpscont.fov = ZoomAmt;
    }
    public void sliderFov(float zoom)
    {
        ZoomAmt = zoom;
    }
}
