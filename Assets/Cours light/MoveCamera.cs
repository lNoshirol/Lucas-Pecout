using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Light myLight;
    public Color myColor;

    private void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        TEUF();
    }

    public void TEUF()
    {
        myColor = new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255));
        myLight.color = myColor;
        myLight.transform.rotation *= new Quaternion(Random.Range(0, 25), Random.Range(0, 25), Random.Range(0, 25), Random.Range(0, 25));
    }
}