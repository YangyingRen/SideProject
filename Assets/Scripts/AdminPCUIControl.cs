using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminPCUIControl : MonoBehaviour
{
    public GameObject BasicInfo,Application;
    public Texture2D clickIcon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    
    }
    public void HoverIn(){
    Cursor.SetCursor(clickIcon, Vector2.zero, CursorMode.Auto);
    }
    public void HoverOut(){
    Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    public void CheckBasicInfo(){
     BasicInfo.SetActive(true);
    }
    public void DiscardBasicInfo(){
    BasicInfo.SetActive(false);

    }
    public void OpenApp(){
        Application.SetActive(true);
        int len=Application.transform.parent.childCount;
        Application.transform.SetSiblingIndex(len-1);
    }
    public void CloseApp(){
        Application.SetActive(false);
    }
}
