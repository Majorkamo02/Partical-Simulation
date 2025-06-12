using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Simulation : MonoBehaviour
{
    [Tooltip("Total number of particles spawned")]
    public int NumberOfParticles;

    List<GameObject> particles = new List<GameObject>();

    public GameObject particle;

    void CreateParticles()
    {
        for (int i = 0; i < NumberOfParticles; i++)
        {
            GameObject newParticle = Object.Instantiate(particle, transform.position, transform.rotation);
            newParticle.name = $"Particle-{i}";
            particles.Add(newParticle);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreateParticles();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
