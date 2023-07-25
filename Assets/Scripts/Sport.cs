using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sport : Car
{
    private float turbo = 1f;

    private void Update()
    {
        //ABSTRACTION
        turboBoost(Input.GetAxis("Jump"));
    }

    //POLYMORPHISM
    public override void Drive(float horizontalInput)
    {
        transform.Translate(Vector3.forward * speed * turbo * Time.deltaTime * horizontalInput);
    }

    private void turboBoost(float input)
    {
        if(input > 0f)
        {
            turbo = 2f;
        }
        else
        {
            turbo = 1f;
        }
    }
}
