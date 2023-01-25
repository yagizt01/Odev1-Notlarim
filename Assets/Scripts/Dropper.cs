using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer dropperRenderer;
    Rigidbody dropperRb;
   [SerializeField] float timeToWait = 3;
    // Start is called before the first frame update
    void Start()
    {
        dropperRenderer = GetComponent<MeshRenderer>();
        dropperRenderer.enabled = false;
        dropperRb = GetComponent<Rigidbody>();
        dropperRb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            dropperRenderer.enabled = true;
            dropperRb.useGravity = true;
            
        }
    }
}
