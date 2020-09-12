using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerTest : MonoBehaviour
{
    // Start is called before the first frame update

    public Sprite Green;
    public Sprite Purple;
    public Sprite Blue;
    void Start()
    {

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
        }
        
       if(collision.gameObject.tag == "RedNeedle")//if the object interacting with blue creature is a red needle.
        {
            print("You have the red needle");
            this.gameObject.GetComponent<Image>().sprite = Purple;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)// When player moves the needles out of the trigger it reverts to it's original color.
    {
        this.gameObject.GetComponent<Image>().sprite = Blue;
    }
}
