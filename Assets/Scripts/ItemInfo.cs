using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{
    public string itemName;

    public string notlooking;
    
    public int itemValue;

    PlayerControl playerScript;


    public bool keylook;
    
    // Start is called before the first frame update
    void Start()
    {
    
     
     playerScript = GameObject.Find("Player").GetComponent<PlayerControl>();  

     
     
    }


    
    void OnMouseOver()
    {
     
     Debug.Log(itemName);
     playerScript.itemText.text = itemName;
   
    }
       
    void OnMouseExit()
    {
     
     Debug.Log(notlooking);
     playerScript.itemText.text = notlooking;
    
    }
        
        
    
       
        
    

    void OnMouseDown()
    {
       playerScript.hasKey = true;
       Destroy(this.gameObject); 

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

