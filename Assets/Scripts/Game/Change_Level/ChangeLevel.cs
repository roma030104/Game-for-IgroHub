using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if (other.TryGetComponent(out Player player)) 
        {
            var index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index + 1);
        }

    }
}
