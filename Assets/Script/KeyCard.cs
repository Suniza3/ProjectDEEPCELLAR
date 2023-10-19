using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class KeyCard : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("key picked up");

            door.GetComponent<BoxCollider2D>().enabled = false;

            this.gameObject.SetActive(false);
        }
    }
}
