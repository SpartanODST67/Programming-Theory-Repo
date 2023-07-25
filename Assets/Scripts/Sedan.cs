using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sedan : Car
{

    // Update is called once per frame
    void Update()
    {
        //ABSTRACTION
        TurnCar(Input.GetAxis("Horizontal"));
    }

    private void TurnCar(float horizontalInput)
    {
        transform.Rotate(Vector3.up * horizontalInput);
    }
}
