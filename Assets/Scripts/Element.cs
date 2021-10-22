using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    // the name card
    public GameObject banner;
    // the entire system of the game
    public Manager manager;
    
    public Sprite uiSprite;
    //public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
        banner.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void OnTriggerEnter(Collider other)
    {
        /* if the element collides with "Player" tag,
           */
        
        if (other.gameObject.CompareTag("Player") )
        {
            manager.UpdateVisualElement(uiSprite);
            banner.SetActive(true);
            GetComponent<Renderer>().enabled = false;
            Destroy(gameObject, 2f);
            
        }
    }
}
