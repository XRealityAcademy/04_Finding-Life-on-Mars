using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element_D : MonoBehaviour
{
    public GameObject banner;
    public Manager_D manager;
    public Sprite uiSprite;

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
         manager.UpdateVisualElement(uiSprite);
         banner.SetActive(true);
         GetComponent<Renderer>().enabled = false;
         Destroy(gameObject, 2f);
    }
}
