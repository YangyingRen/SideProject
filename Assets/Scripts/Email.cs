using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Email : MonoBehaviour
{
    private Transform Content;
    public string[] EmailDetail;
    public GameObject EmailName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void emailContent(){
    GameObject.Find("From").GetComponent<Text>().text=EmailDetail[0];
    GameObject.Find("Date").GetComponent<Text>().text=EmailDetail[1];
    GameObject.Find("To").GetComponent<Text>().text=EmailDetail[2];
    GameObject.Find("Subject").GetComponent<Text>().text=EmailDetail[3];
    Content=GameObject.Find("emailText").GetComponent<RectTransform>();
    if(Content.childCount!=0){
    Destroy(Content.GetChild(0).gameObject);
    }
    GameObject newContent=Instantiate(EmailName,Content);
    GameObject.Find("emailContent").GetComponent<ScrollRect>().content=newContent.GetComponent<RectTransform>();
    gameObject.GetComponent<Text>().fontStyle=FontStyle.Normal;
}}
