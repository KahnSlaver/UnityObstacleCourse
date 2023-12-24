using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int timeBeforeDrop = 3;
    [SerializeField] int timeVisible = 1;

    MeshRenderer meshRenderer;
    Rigidbody rigidBody;

    void Start() 
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        rigidBody.useGravity = false;
        meshRenderer.enabled = false;
    }
    

    void Update()
    {
        if (Time.time > timeBeforeDrop - timeVisible)
        {
            meshRenderer.enabled = true;
        }
        if (Time.time > timeBeforeDrop)
        {
            rigidBody.useGravity = true;
            if (rigidBody.velocity == Vector3.zero && Time.time > timeBeforeDrop + 0.1f)
            {
                rigidBody.constraints = RigidbodyConstraints.FreezeAll;
            }
        }
    }
}
