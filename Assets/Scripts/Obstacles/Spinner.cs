using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 3f;
    // Update is called once per frame
    void Update()
    {   
        Vector3 yRotation = Vector3.up * Time.deltaTime * rotationSpeed;
        transform.Rotate(yRotation);
    }
}
