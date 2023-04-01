using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZlackInteraction : MonoBehaviour
{
    public GameObject MemberList, chooseChannel;
    private GameObject chosenChannel;
    public Transform Channels;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
   
    }
    public void CheckMemberList(){
    MemberList.SetActive(true);
    }
    public void UnCheckMemberList(){
    MemberList.SetActive(false);
    }

    public void ChooseChannel(){
    if(Channels.childCount!=0){
     Destroy(Channels.GetChild(0).gameObject);
    }
    chosenChannel=Instantiate(chooseChannel,Channels);
     chosenChannel.transform.SetParent(Channels);    }
}
