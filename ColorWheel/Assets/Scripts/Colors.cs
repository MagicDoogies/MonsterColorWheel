using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[CreateAssetMenu (fileName ="Colors", menuName ="MonsterColor", order=1)] 
public class Colors: ScriptableObject
{
    public string color;
    public string type;
    public string unlockText;
    public bool isPrimary;
    public bool isSecondary;
    public bool isTertiary;
    public bool isPastel;

    public Colors redNeedleUnlock;
    public Colors yellowNeedleUnlock;




    public Sprite sprite;

    public Colors(string newColor, string newType)
    {
        color = newColor;
        type = newType;
    }

}
