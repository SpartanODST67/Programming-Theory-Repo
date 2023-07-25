using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private protected float speed;
    public virtual void Drive(float horizontalInput)
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime * horizontalInput);
    }
}
