using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    public float TimeCount=1800;
    private int Hours,Minutes;
    public Image TimeCountBar;
    public Text TimeDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if(TimeCount>0){
    TimeCount-=Time.deltaTime;}
    else{
    TimeCount=0;
    }

    TimeCountBar.fillAmount=TimeCount/1800f;
    Hours=10+(int)(((1800f-TimeCount)*16f)/3600f);
    Minutes=(int)((((1800f-TimeCount)*16f)%3600f)/60f);
    TimeDisplay.text=Hours.ToString()+" ："+Minutes.ToString("00");
    }
}
