using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Finish : MonoBehaviour
{
    private UnityEngine.Vector3 FinishMate = new UnityEngine.Vector3 (48.9000015f,-20.1386948f,108.5f);
    // Start is called before the first frame updat
    private void OnCollisionEnter(Collision other) 
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }
}
