using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] GameObject gate; //Сюда кидаем ваш геймобжект ворота
    private void OnTriggerEnter(Collider other) 
    {
        if (other.TryGetComponent(out Player player)) 
        {
            Destroy(gate);
        }

    }
}
