using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FilesInteraction : MonoBehaviour, IPointerClickHandler
{
    public Transform InfoContent, MotherLayer;
    public GameObject DeleteBar, NextFile, CloseInfoButton;
    public int FileIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    if(DeleteBar.GetComponent<Slider>().value>=0.99){
    InfoContent.GetChild(0).SetParent(transform);
    Destroy(gameObject);
    CloseInfoButton.SetActive(false);
    }
        
    }

    public void OnPointerClick(PointerEventData eventData){
    if(eventData.button==PointerEventData.InputButton.Right){
       transform.GetChild(1).gameObject.SetActive(true);
       transform.GetChild(1).SetParent(InfoContent);
       CloseInfoButton.SetActive(true);
       FileIndex=transform.GetSiblingIndex();
       MotherLayer.gameObject.GetComponent<FilesInteraction>().FileIndex=FileIndex;
    }
    }

    public void OpenFile(){
        NextFile.SetActive(true);
    }
    public void CloseInfo(){
        if(InfoContent.childCount!=0){
        InfoContent.GetChild(0).gameObject.SetActive(false);
        InfoContent.GetChild(0).SetParent(transform.GetChild(FileIndex));
        CloseInfoButton.SetActive(false);
        }
    }

    public void Back(){
        int LayerIndex=transform.parent.parent.GetSiblingIndex();
        if(LayerIndex>2){
           NextFile.SetActive(false);
        }
    }
}
