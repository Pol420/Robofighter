using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandWeapon : Weapon
{
    [Header("Physics")]
    [SerializeField] [Range(0f, 100f)] private float shotPower = 20f;
    [SerializeField] [Range(0f, 5f)] private float weight = 0f;
    [SerializeField] [Range(0f, 100f)] private float damage = 20f;
    [SerializeField] [Range(0f, 40f)] private float bps = 6f;

    protected override void Shoot(GameObject bullet)
    {
        bullet.GetComponent<Projectile>().ShootProjectile(bulletHole.position, cam.transform.forward, damage, shotPower, weight);
    }

    protected override void SubStart()
    {
        reloadTime = 1f / bps;
    }

    protected override void SubUpdate()
    {

    }
}
