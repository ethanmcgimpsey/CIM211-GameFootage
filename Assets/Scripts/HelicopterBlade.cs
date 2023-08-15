using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterBlade : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,1 * rotateSpeed * Time.deltaTime);
    }
}
