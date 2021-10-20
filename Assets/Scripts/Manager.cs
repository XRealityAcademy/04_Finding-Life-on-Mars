using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class Manager : MonoBehaviour
{
    public  List<Image> collectedElements;

    private  int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public  void UpdateVisualElement(Sprite elementSprite)
    {
        if (counter < collectedElements.Count)
        {
            collectedElements[counter].sprite = elementSprite;
            counter++;
        }
       
    }
}
