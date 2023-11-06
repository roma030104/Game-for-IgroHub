using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel_2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if (other.TryGetComponent(out Player player)) 
        {
            SceneManager.LoadScene("lvl_3");
        }

    }
}
