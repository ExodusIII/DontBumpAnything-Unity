using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]float x = 0f;
    [SerializeField]float y = 0f;
    [SerializeField]float z = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x,y,z);
    }
}
