using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise5 : MonoBehaviour
{
    private int Number;
    public TMP_InputField Text;

    private int Animal;
    public Image ImageAnimal;
    public Sprite[] animalSprite;
   

    void Update()
    {
        if (Text.text != "")
        {
            ImageAnimal.gameObject.SetActive(true);
            Number = int.Parse(Text.text); //This transfers the text to an int
            Animal = Number % 12; 
            ImageAnimal.sprite = animalSprite[Animal];
        }
    }
}
