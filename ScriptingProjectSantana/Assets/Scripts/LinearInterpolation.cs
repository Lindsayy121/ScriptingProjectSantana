using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{/*
  * float result = Mathf.Lerp (3f, 5f, 0.5f);
  * the Mathf.Lerp funtion takes 3 float parameters:representing the value to interpolation form, representing the value to interpolate to and a float representing how far to interpolate
  * 
  * Vector3 from = new Vector3 (1f, 2f, 3f);
  * Vector3 to = new Vector3 (5f, 6f, 7f);
  * Vector3 result = Vector3.Lerp (from, to, 0.75);
  * work the same way as Mathf.Lerp but the ‘from’ and ‘to’ values are of type Color and Vector3 respectively.
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        light.intenseity = Mathf.Lerp(light. intensity, 8f, 0.5f);
    *the lights intensity will tend towards 8 but the rate of its change will slow as it approaches its target
    *
    *light. intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
    *This would mean the change to intensity would happen per second instead of per frame.
    }
    */
}
