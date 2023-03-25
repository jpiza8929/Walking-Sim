using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
   PlayerControl playercontrol;

   public string Door, notdoor;
   
    // Start is called before the first frame update
    void Start()
    {
        playercontrol = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if(playercontrol.hasKey == true)
        {
            Destroy(this.gameObject);
        }
    }

    void OnMouseOver()
    {
        playercontrol.itemText.text = Door; 
    }

    void OnMouseExit()
    {
        playercontrol.itemText.text = notdoor; 
    }
}
