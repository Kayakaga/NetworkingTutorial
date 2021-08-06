using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Debugging : MonoBehaviour
{
    Text debugText;
    Vector3 camPos;
    GameObject cam;
    void Start()
    {
        debugText = GetComponent<Text>();
        cam = GameObject.FindGameObjectWithTag("MainCamera");
    }
    void Update()
    {
        camPos = cam.transform.position;
        debugText.text = "x: " + camPos.x + " y: " + camPos.y + " z: " + camPos.z;
    }
}
