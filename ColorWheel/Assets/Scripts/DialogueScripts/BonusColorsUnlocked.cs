using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusColorsUnlocked : MonoBehaviour
{
    // Start is called before the first frame update
    public Colors player;
    public Colors higherUp;
    public Colors scientist;

    public ColorContainer unlockedColors;


    public void Awake()
    {
        unlockedColors.elements.Add(player);
        unlockedColors.elements.Add(higherUp);
        unlockedColors.elements.Add(scientist);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
