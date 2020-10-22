using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResultsBox : MonoBehaviour
{
    public TriggerTest triggerTest;
    public Colors currentColor;
   

    public TMP_Text needleColor;
    public TMP_Text color2; 
    public Image resultImage;
    // Start is called before the first frame update
    void Start()
    {
        currentColor = triggerTest.currentColor;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentColor != triggerTest.currentColor)
        {
            currentColor = triggerTest.currentColor;
        }
    }

    public void MonsterChange(Colors resultColor)
    {
        if (resultColor.color != "Clear")
        {
            resultImage.sprite = resultColor.sprite;

           
        }
        color2.text = resultColor.color;

    }
    public void NeedleClicked(GameObject needleTag)
    {
        
        needleColor.text = needleTag.tag;
        if( needleTag.tag == "Red")
        {
            Debug.Log(needleColor.text);
            resultImage.sprite = currentColor.redNeedleUnlock.sprite;
           
        }
        if (needleTag.tag == "Blue")
        {
            Debug.Log(needleColor.text);
            resultImage.sprite = currentColor.blueNeedleUnlocked.sprite;
        }
        if(needleTag.tag == "Yellow")
        {
            Debug.Log(needleColor.text);
            resultImage.sprite = currentColor.yellowNeedleUnlock.sprite; 
        }
        if(needleTag.tag == "PastelBlue")
        {
            Debug.Log(needleColor.text);
            resultImage.sprite = currentColor.pastelBlueUnlocked.sprite;
        }
        if(needleTag.tag == "PastelRed")
        {
            Debug.Log(needleColor.text);
            resultImage.sprite = currentColor.pastelRedUnlocked.sprite;
        }
        if(needleTag.tag == "PastelYellow")
        {
            Debug.Log(needleColor.text);
            resultImage.sprite = currentColor.pastelYellowunlocked.sprite;
        }
    }
    
}
