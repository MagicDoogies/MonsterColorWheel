﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class TriggerTest : MonoBehaviour
{
    // Start is called before the first frame update

    public Sprite Green;
    public Sprite Purple;
    public Sprite Blue;

    ColorsList colorList;


    void Start()
    {
        colorList = GameObject.Find("ListManager").GetComponent<ColorsList>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        print("You activated me");
       if(collision.gameObject.tag == "YellowNeedle")//if the object interacting with blue creature is a yellow needle.
        {
            print(" You have the yellow needle");
            this.gameObject.GetComponent<Image>().sprite = Green;
            colorList.MonsterColors.Add(new Colors("Green", "Secondary"));

        }

        if (collision.gameObject.tag == "RedNeedle")//if the object interacting with blue creature is a red needle.
        {
            print("You have the red needle");
            this.gameObject.GetComponent<Image>().sprite = Purple;
            colorList.MonsterColors.Add(new Colors("Purple", "Secondary"));
        }
    }

    public void OnTriggerExit2D(Collider2D collision)// When player moves the needles out of the trigger it reverts to it's original color.
    {
        this.gameObject.GetComponent<Image>().sprite = Blue;
    }
}
