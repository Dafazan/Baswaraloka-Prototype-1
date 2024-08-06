using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float health;
    

    [SerializeField] GameObject cube2;
    void Start()
    {
        cube2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
