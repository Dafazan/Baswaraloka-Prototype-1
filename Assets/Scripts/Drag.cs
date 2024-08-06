using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    [SerializeField] private LayerMask PickupMask;
    [SerializeField] private Camera PlayerCamera;
    [SerializeField] private Transform PickupTarget;
    [Space]
    [SerializeField] private float PickupRange;
    private Rigidbody CurrentObj;
    RaycastHit hit;
    Ray ray;
    bool isTvOn = false;
    public GameObject video;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == "CubeHit")
                {
                    if (!isTvOn)
                    {
                        isTvOn = true;
                        video.SetActive(true);
                    }
                    else
                    {
                        isTvOn = false;
                        video.SetActive(false);
                    }
                }

            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            
                if (CurrentObj)
            {
                CurrentObj.useGravity = true;
                CurrentObj = null;
                return;
            }
            Ray CameraRay = PlayerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
            if(Physics.Raycast(CameraRay, out RaycastHit HitInfo, PickupRange, PickupMask))
            {
                CurrentObj = HitInfo.rigidbody;
                CurrentObj.useGravity = false;
            }
        }
    }
    private void FixedUpdate()
    {
        if (CurrentObj)
        {
            Vector3 DirectionToPoint = PickupTarget.position - CurrentObj.position;
            float DistanceToPoint = DirectionToPoint.magnitude;

            CurrentObj.velocity = DirectionToPoint * 32f * DistanceToPoint;
        }
    }
}
