using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turns : MonoBehaviour
{
    private string state;

    // Start is called before the first frame update
    void Start()
    {
        setup();
    }
        
       public void setup()
    {
        // create map 
        // spawn player objects around map 
        // and enemies
 
        PlayerTurn();
    }

    private void PlayerTurn()
    {

        // call from James
        // check 
        Enemyturn();

    }

    private void Enemyturn()
    {
        // call from James
        //check
        PlayerTurn();

    }
    private void Check()
    {
        int enemycount = 0;
        int playercount = 0;
        // call something count enemy object
        if(enemycount == 0)
        {
            state = "W";
            EndGame();
        }
        // count player object
        if (playercount == 0)
        {
            state = "L";
            EndGame();
        }

    }
    private void EndGame()
    {
        if(state == "W")
        {
            // win message
            // return to map
        }
        else
        {

            // lose message
            // return to map
        }
        
         }

    }
