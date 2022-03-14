using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int rotationSpeed=60;
    float horizontalMovement;
  
    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontalMovement);
    }
}
