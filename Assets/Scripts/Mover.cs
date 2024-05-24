using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]int Speed = 50;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float XValue = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
        float ZValue = Input.GetAxis("Vertical") * Time.deltaTime * Speed;
        //Debug.Log("XValue: " + XValue + ", ZValue: " + ZValue);
        transform.Translate(XValue,0,ZValue);
    }
}
