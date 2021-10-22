using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class Manager : MonoBehaviour
{
    public  List<Image> collectedElements;
    public int countLimit = 6;

    private  int counter = 0;

    public GameObject gameWin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*When it is called, if the counter (for the sprite ui to show) is less than the entire UI sprite counts, then show the
     sprite that being pass on to current count*/
    public  void UpdateVisualElement(Sprite elementSprite)
    {
        if (counter < collectedElements.Count)
        {
            collectedElements[counter].sprite = elementSprite;
            counter++;
        }

        if (counter == countLimit)
        {
            gameWin.SetActive(true);
        }
       
    }
    
    
}
