using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    float xVal = 0;
    float zVal = 0;

    [SerializeField] float movementSpeed = 0;

    // Update is called once per frame
    void Update()
    {
        xVal = Time.deltaTime * movementSpeed * Input.GetAxis("Horizontal");
        zVal = Time.deltaTime * movementSpeed * Input.GetAxis("Vertical");

        transform.Translate(xVal,0,zVal);
    }
}
