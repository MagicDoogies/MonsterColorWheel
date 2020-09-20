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
