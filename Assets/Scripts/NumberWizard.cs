using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int low, high;
    // Start is called before the first frame update
    void Start()
    {
        startGame();
    }

    void startGame()
    {
        high = 1000;
        low = 1;
        Debug.Log("Welcome to number wizard!");
        Debug.Log("Pick a number boii :)");
        Debug.Log("Lowest dude is " + low);
        Debug.Log("highest dude is " + high);
        Debug.Log("Up is higher, Down is lower, Enter is correct");
        step();
    }
    int Guess()
    {
        return (low + high) / 2;
    }

    void step()
    {
        Debug.Log("Is it lower or higher than " + Guess());  
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            low = Guess();
            step();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            high = Guess();
            step();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Ayyyyy ezzzz");
     
            startGame();
        }
    }
}
