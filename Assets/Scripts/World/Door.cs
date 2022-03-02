using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] int ItemIdToOpen = 0;
    [SerializeField] float OpeningSpeed = 0.3f;

    private bool DoorOpening = false;

    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !DoorOpening)
        {
            if (other.gameObject.GetComponentInParent<PlayerInventory>().DeleteItem(ItemIdToOpen))
            {
                DoorOpening = true;
                //Debug.Log("Door opened");
            }
        }
    }

    private void FixedUpdate()
    {
        if (DoorOpening)
        {
            Vector3 scale = gameObject.transform.localScale;
            if (scale.y >= OpeningSpeed)
            {
                gameObject.transform.localScale = new Vector3(scale.x, scale.y - OpeningSpeed, scale.z);
                gameObject.transform.Translate(new Vector3(0, OpeningSpeed / 2, 0));
            }
            else
            {
                DoorOpening = false;
            }
        }
    }
}
