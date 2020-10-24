using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MonsterCounter : MonoBehaviour
{
    public ColorContainer currentlyUnlockedColors;
    public TMP_Text unlockedTracker;

    public int currentCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        UnlockedColorsCounter();
    }

    public void UnlockedColorsCounter()
    {
        currentCount = currentlyUnlockedColors.elements.Count;//Sets the variable count to 
        unlockedTracker.SetText(currentCount.ToString());//translates the current number of elements in unlocked colors to the tracker in Logbook screen. 

    }
}
