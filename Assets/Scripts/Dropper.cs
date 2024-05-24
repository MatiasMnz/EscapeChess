using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
public class Dropper : MonoBehaviour
{
    //private Vector3 PreasurePlate = new Vector3(-66.1997452f, -20.1386948f, 88.8000031f);
    // [SerializeField]int Seconds = 3;

    void Start()
    {
        GameObject[] keys = GameObject.FindGameObjectsWithTag("Key");
        foreach (GameObject key in keys)
        {
            MeshRenderer renderer = key.GetComponent<MeshRenderer>();
            Rigidbody body = key.GetComponent<Rigidbody>();

            if (renderer != null)
            {
                renderer.enabled = false;
            }
            else
            {
                Debug.LogError("MeshRenderer no encontrado en el GameObject.");
            }

            if (body != null)
            {
                body.useGravity = false;
            }
            else
            {
                Debug.LogError("Rigidbody no encontrado en el GameObject.");
            }
        }
    }

    void Update()
    {
        // Timer();
    }

    // void Timer()
    // {
    //     if (Time.time >= Seconds)
    //     {
    //         GameObject[] keys = GameObject.FindGameObjectsWithTag("Key");
    //         foreach (GameObject key in keys)
    //         {
    //             MeshRenderer renderer = key.GetComponent<MeshRenderer>();
    //             Rigidbody body = key.GetComponent<Rigidbody>();
    //             renderer.enabled = true;
    //             body.useGravity = true;
    //         }
    //     }
    // }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject[] keys = GameObject.FindGameObjectsWithTag("Key");
            foreach (GameObject key in keys)
            {
                MeshRenderer renderer = key.GetComponent<MeshRenderer>();
                Rigidbody body = key.GetComponent<Rigidbody>();

                if (renderer != null)
                {
                    renderer.enabled = true;
                }

                if (body != null)
                {
                    body.useGravity = true;
                }
            }
        }
    }
}

