using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");

        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerUI>().treasureCollected++;
        }

        RemoveTreasure();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger enter");

        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerUI>().treasureCollected++;
        }

        RemoveTreasure();
    }

    private void RemoveTreasure()
    {
        Destroy(gameObject);
    }
}
