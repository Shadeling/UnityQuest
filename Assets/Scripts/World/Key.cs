using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Key : IPickAble
{
    // Start is called before the first frame update
    [SerializeField] int KeyID;

    private MyAudioManager audioManager;


    private void Start()
    {
        this.ID = KeyID;
        this.name = "Key"+KeyID;
        audioManager = FindObjectOfType<MyAudioManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OnPickUp();
        }
    }

    public override void OnPickUp()
    {
        audioManager.PlayKeyPickUpSound();
        FindObjectOfType<PlayerInventory>().AddItem(this);
        //Debug.Log("Key Picked Up");
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
