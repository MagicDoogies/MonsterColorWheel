using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue 
{
    // Start is called before the first frame update
    public string name;

    [TextArea(4, 10)]//Expands the text box area of the sentences. 
    public string[] sentences; //An array of the actual sentences that will be displayed in the dialogue box. 

   
}
