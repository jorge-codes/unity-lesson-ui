using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public float sizeMin = 0.1f;
    public float sizeMax = 1.0f;
    public float speed = 10f;
    public Vector3 particleRotation;
    public Rigidbody rb = null;

    public void Setup(Vector3 wallPosition)
    {
        var size = Random.Range(sizeMin, sizeMax);
        transform.localScale = new Vector3(size, size, size);
        // transform.position = wallPosition + Random.insideUnitSphere * 2.5f;
    }
    
    public void Shoot(Vector3 direction)
    {
        transform.forward = direction.normalized;
        rb.AddForce(direction * speed);
    }
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Time.deltaTime * particleRotation);
    }
}
