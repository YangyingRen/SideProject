using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour
{
    public Transform Channels;
    public GameObject chosenChannel;
    public Color selectedColor;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {if(Channels.childCount!=0){
         if(Channels.GetChild(0).gameObject.name==chosenChannel.name+"(Clone)"){
        ColorBlock cb=gameObject.GetComponent<Button>().colors;
       cb.normalColor= selectedColor;
       gameObject.GetComponent<Button>().colors=cb;
    }
    else{
        ColorBlock cb=gameObject.GetComponent<Button>().colors;
       cb.normalColor= new Color(1,1,1,0);
       gameObject.GetComponent<Button>().colors=cb;
    }
        
    }}
}
