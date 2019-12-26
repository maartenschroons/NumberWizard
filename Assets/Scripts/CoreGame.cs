using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoreGame : MonoBehaviour
{
    [SerializeField] int low, high;
    [SerializeField] Text guess;
    // Start is called before the first frame update
    void Start()
    {
        startGame();
    }

    void startGame()
    {
        high++;
        step();
    }
    int Guess()
    {
        return Random.Range(low, high);
    }

    void step()
    {
        guess.text = Guess().ToString();
    }


    public void higher()
    {
        low = Guess()-1;
        step();
    }

    public void lower()
    {
        high = Guess()+1;
        step();
    }

  
}
