using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorsList : MonoBehaviour

{
   public List<Colors> MonsterColors;
    // Start is called before the first frame update
    void Start()
    {
        MonsterColors = new List<Colors>();//initialiaze the color list.

        MonsterColors.Add(new Colors("Blue", "Primary"));//since the color blue is 
        MonsterColors.Add(new Colors("Red", "Primary"));
        MonsterColors.Add(new Colors("Yellow", "Primary"));
        MonsterColors.Add(new Colors("Orange", "Secondary"));
        MonsterColors.Add(new Colors("Green", "Secondary"));
        MonsterColors.Add(new Colors("Purple", "Secondary"));
        MonsterColors.Add(new Colors("Lime", "Tertiary"));
        MonsterColors.Add(new Colors("Magenta", "Tertiary"));
        MonsterColors.Add(new Colors("Teal", "Tertiary"));
        MonsterColors.Add(new Colors("Vermillion", "Tertiary"));
        MonsterColors.Add(new Colors("Amber", "Tertiary"));
        MonsterColors.Add(new Colors("Violet", "Tertiary"));
        MonsterColors.Add(new Colors("Brown", "Neutral"));
        MonsterColors.Add(new Colors("Blush", "Pastel"));
        MonsterColors.Add(new Colors("Sky", "Pastel"));
        MonsterColors.Add(new Colors("Custard", "Pastel"));
        MonsterColors.Add(new Colors("Seafoam", "Pastel"));
        MonsterColors.Add(new Colors("Peach", "Pastel"));
        MonsterColors.Add(new Colors("Orchid", "Pastel"));
        MonsterColors.Add(new Colors("Sand", "Pastel"));
        MonsterColors.Add(new Colors("Crystal", "Pastel"));
        MonsterColors.Add(new Colors("Coral", "Pastel"));
        MonsterColors.Add(new Colors("Blueberry", "Pastel"));
        MonsterColors.Add(new Colors("Bubblegum", "Pastel"));
        MonsterColors.Add(new Colors("Chartreuse", "Pastel"));
        MonsterColors.Add(new Colors("Coffee", "Neutral"));
        
        /*foreach(Colors color in MonsterColors)//read through the list and display what colors are currently in the console.
        {
            print(color.color + " " + color.type + " ");
        }*/

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Colors color in MonsterColors)//read through the list and display what colors are currently in the console.
        {
            print(color.color + " " + color.type + " ");
        }
    }
}
