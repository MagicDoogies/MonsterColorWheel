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
    //these are all containters for sprites that will be displayed when players use a specific needle to interact with a color. 
    public Colors redNeedleUnlock;
    public Colors yellowNeedleUnlock;
    public Colors blueNeedleUnlocked;
    public Colors greenNeedleUnlock;
    public Colors orangeNeedleUnlock;
    public Colors purpleNeedleUnlocked;
    public Colors limeNeedleUnlock;
    public Colors magentaNeedleUnlock;
    public Colors tealNeedleUnlocked;
    public Colors vermillionNeedleUnlock;
    public Colors violetNeedleUnlock;
    public Colors amberNeedleUnlocked;
    public Colors blushNeedleUnlock;
    public Colors skyNeedleUnlock;
    public Colors custardNeedleUnlocked;
    public Colors orchidNeedleUnlock;
    public Colors seafoamNeedleUnlock;
    public Colors peachNeedleUnlocked;
    public Colors crystalNeedleUnlock;
    public Colors coralNeedleUnlock;
    public Colors blueberryNeedleUnlocked;
    public Colors bubblegumNeedleUnlock;
    public Colors chartreuseNeedleUnlock;
    public Colors coffeeNeedleUnlocked;
    public Colors brownNeedleUnlocked;

    public Sprite sprite;

    public Colors(string newColor, string newType)
    {
        color = newColor;
        type = newType;
    }

}
