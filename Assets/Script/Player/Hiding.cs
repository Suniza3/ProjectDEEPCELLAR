using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOV : MonoBehaviour
{
    public SpriteRenderer sr;
    public bool PlayerHide = false;
    public bool hiding = false;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        if (PlayerHide && Input.GetKeyDown(KeyCode.V))
        {
            Physics2D.IgnoreLayerCollision(6, 7, true);
            sr.sortingOrder = 0;
            PlayerHide = true;
        }
        else
        {
            Physics2D.IgnoreLayerCollision(6, 7, false);
            sr.sortingOrder = 0;
            PlayerHide = false;
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Locker"))
        {
            PlayerHide = true;
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Locker"))
        {
            PlayerHide = false;
        }
    }


}
