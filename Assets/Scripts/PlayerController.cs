using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //POLYMORPHISM
    private Car engine;

    private void Start()
    {
        engine = GetComponent<Car>();
    }

    // Update is called once per frame
    void Update()
    {
        engine.Drive(Input.GetAxis("Vertical"));
    }
}
