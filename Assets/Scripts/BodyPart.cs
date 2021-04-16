using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPart : MonoBehaviour
{
    [SerializeField] [Range(0f, 3f)] private float damageMultiplier = 1f;
    private GameObject floatyText;
    private Enemy body;

    public void Connect(Enemy parentBody, GameObject floatyText)
    {
        body = parentBody;
        this.floatyText = floatyText;
    }

    void Start()
    {
        
    }
    

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("PlayerProjectile")) Hurt(collision.contacts[0].point, (collision.contacts[0].point - transform.position).normalized, (int)damageMultiplier * collision.gameObject.GetComponent<Projectile>().damage);
    }

    private void Hurt(Vector3 position, Vector3 direction, int damage)
    {
        body.Hurt(damage);
        Instantiate(floatyText).GetComponent<FloatyText>().Init(position, direction, damage);
    }

}
