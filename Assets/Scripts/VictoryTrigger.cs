using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Victory triggered");
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(2);
            Debug.Log("Victory trigger full functionality");
        } 
    }
}
