using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizerd : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    bool ftimer = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Number Wizerd \nGuess a number between " +min +" to "+max);
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (ftimer)
        {
            guess = (max + min) / 2;
        }
        Debug.Log("Is this the number : " + guess);
        Debug.Log("If the number is correct press Enter \nIf the Number is higher then press Up or If lower press Down");
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Thank you for playing");
            enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ftimer = true;
            min = guess;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ftimer = true;
            max = guess;
        }
    }
}
