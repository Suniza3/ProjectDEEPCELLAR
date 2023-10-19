using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGetKey : MonoBehaviour
{
    [SerializeField]

    public GameObject MessagePanel;
    public GameObject door;

    public bool Action = false;

    void Start()
    {
        MessagePanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action == true)
            {
                MessagePanel.SetActive(false);
                Action = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MessagePanel.SetActive(true);
            Action = true;

            Debug.Log("key picked up");

            door.GetComponent<BoxCollider2D>().enabled = false;

        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MessagePanel.SetActive(false);
            Action = false;
            this.gameObject.SetActive(false);
        }
    }
}
