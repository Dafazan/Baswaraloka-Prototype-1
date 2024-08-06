using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClose : MonoBehaviour
{
    Animator lmdAnimator;
    private Animator ldAnimator;

    [SerializeField] GameObject ldAnim;

    Ray ray;
    RaycastHit hit;

    bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        lmdAnimator = ldAnim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider.gameObject.name == "HandleMDoorL")
                {
                    if (lmdAnimator != null)
                    {
                        if (!isOpen)
                        {
                            lmdAnimator.SetTrigger("open");
                            isOpen = true;
                        }
                        else
                        {
                            lmdAnimator.SetTrigger("close");
                            isOpen = false;
                        }

                    }
                }
            }
        }  
    }
   
}
