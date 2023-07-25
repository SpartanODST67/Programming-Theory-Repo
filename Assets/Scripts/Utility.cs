using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Utility : Car
{
    [SerializeField] private GameObject crate;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //ABSTRACTION
            DropCrate();
        }
    }

    private void DropCrate()
    {
        Instantiate(crate, new Vector3(transform.position.x, transform.position.y, transform.position.z - 5f), crate.transform.rotation);
    }
}
