using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public GameObject bulletPrefab;
    private Transform transform;

    public float timeToInitialFire = 2f;
    public float rateOfFire = 5f;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        InvokeRepeating("Shoot", this.timeToInitialFire, this.rateOfFire);
    }

    // Duplicate in EnemyGun and BulletSpawner
    void Shoot()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

    private void OnDisable()
    {
        CancelInvoke("Shoot");
    }
}
