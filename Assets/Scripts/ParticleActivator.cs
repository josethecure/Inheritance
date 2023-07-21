using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleActivator : MonoBehaviour
{

    public ParticleSystem particleSystem;

    private void Update()
    {
        // Check for right mouse button click
        if (Input.GetMouseButtonDown(1)) 
        {
            // Activate the particle system
            particleSystem.Play();
        }
    }
}
