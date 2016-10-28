using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour
{
    //partie de mouvement du projectile
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;
    public float speed = 20;
    // Use this for initialization

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //lancé des projectiles
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, transform.position, transform.rotation);
        }
    }
}
