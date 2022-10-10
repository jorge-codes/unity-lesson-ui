using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    [SerializeField] private ParticleController particlesPrefab = null;
    [SerializeField] private int numOfParticles = 10;
    public int NumOfParticles => numOfParticles;
    public void Explode(int num = 10)
    {
        for (var i = 0; i < num; i++)
        {
            var particle = Instantiate(particlesPrefab, transform.position, Quaternion.identity);
            particle.Setup(transform.position);
            particle.Shoot(Random.insideUnitSphere);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
