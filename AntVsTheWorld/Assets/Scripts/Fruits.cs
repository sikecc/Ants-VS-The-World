using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        var hit = collision.gameObject;
        var hitPlayer = hit.GetComponent<Player>();
        if(hitPlayer != null)
        {
            var health = hit.GetComponent<Health>();
            health.AddHealth(10);
            Destroy(gameObject);
        }
    }
}
