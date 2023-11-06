using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Vector3 Teleport_Point;
    private void OnTriggerEnter(Collider other) 
    {
        if (other.TryGetComponent(out Player player)) 
        {
            player.transform.position = Teleport_Point;
            Destroy(gameObject);
        }

    }
}
