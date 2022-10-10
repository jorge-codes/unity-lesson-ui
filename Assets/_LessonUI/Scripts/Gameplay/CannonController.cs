using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CannonController : MonoBehaviour
{
    // [Header("Simple Prefab Config")]
    // [SerializeField] private BulletController bulletPrefab = null;

    [Header("Array Prafab Config")]
    [SerializeField] private BulletController[] bulletPrefabs;

    [Space(20)]
    [SerializeField] private Transform mountPoint = null;
    [SerializeField] private float angularSpeed = 6f;

    private int shootCounter;

    public void Shoot(int projectileIndex)
    {
        // var bullet = Instantiate(bulletPrefab, mountPoint.position, Quaternion.identity);

        var prefab = bulletPrefabs[projectileIndex];
        var bullet = Instantiate(prefab, mountPoint.position, Quaternion.identity);
        bullet.SetDirection(mountPoint.forward);
        shootCounter++;
    }

    private void Awake()
    {
        shootCounter = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot(1);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot(0);
        }

        var horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontal * angularSpeed, Space.Self);

    }
    
}
