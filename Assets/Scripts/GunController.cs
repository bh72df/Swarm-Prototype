using UnityEngine;

public class GunController : MonoBehaviour
{
    public Transform gunBarrel; 
    public GameObject bulletPrefab; 

    public float fireRate = 0.5f; 
    private float nextFireTime = 0f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFireTime)
        {
            Shoot(); // Call the shoot function
        }
    }

    void Shoot()
    {
        nextFireTime = Time.time + 1f / fireRate;

        GameObject bullet = Instantiate(bulletPrefab, gunBarrel.position, gunBarrel.rotation);

        bullet.GetComponent<Rigidbody>().AddForce(gunBarrel.forward * 50f, ForceMode.Impulse);

        Destroy(bullet, 2f);
    }
}
