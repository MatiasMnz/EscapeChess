using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float XAngle = 0f;
    [SerializeField] float YAngle = 0f;
    [SerializeField] float ZAngle = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(XAngle,YAngle,ZAngle);
    }
}

