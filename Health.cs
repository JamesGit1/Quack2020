using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health
{
    private int hp;
    private int max;
    public Health(int hp)
    {
        this.hp = hp;
        max = hp;
    }
    public int GetHP()
    {
        return hp;
    }

    public void Dmg(int dmgAmount)
    {
        
        hp = hp - dmgAmount;
        if(hp <= 0)
        {
                // delete player / enemy 
                // 
        }
    }

    public void Heal(int healAmount)
    {

        if (hp != max)
        {    
            hp = hp + healAmount;

            if(hp> 100)
            {
                hp = 100;
            }
        }
        else
        {

            // Display no heal message

        }
    }
}
