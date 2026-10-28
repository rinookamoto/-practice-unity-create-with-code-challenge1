using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotateSpeed = 10000.0f;

    void Update() 
    {
     transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
    }

}
