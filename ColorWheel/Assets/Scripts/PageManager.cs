using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManager : MonoBehaviour

{
    public List<LogBook> logBookPages = new List<LogBook>();

    public GameObject pageOne;
    // Start is called before the first frame update
    void Start()
    {
        logBookPages.Add(pageOne.GetComponent<LogBook>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
