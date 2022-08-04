using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{ 
    string heroName = "butcher";
    int heroPower = 7;
    string villianName = "Homelander";
    int villianPower = 30;
    float playerSpeed = 4.4f;
    float oldSpeed =0f;
    float NewSpeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        if (heroPower > villianPower)
        {
            print(heroName + (" is more powerful then " + villianName));
        }
        else if (villianPower > heroPower)
        {
            print(villianName + (" is more powerful then " + heroName));
        }
        else 
        {
            print(villianName + (" is as powerful as " + heroName));
        }
          setSpeed(2.5f);

          ComapreSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setSpeed (float newSpeed)
    {
        print("old speed is " + playerSpeed);
        oldSpeed = playerSpeed;
        playerSpeed = newSpeed;
        print("new speed is " + playerSpeed);
        NewSpeed = newSpeed;
    }
    
    void ComapreSpeed()
    {
        if (oldSpeed > NewSpeed)
        {
            print(" Old speed: " + oldSpeed + " is faster then newspeed");
        }
        else if (oldSpeed < NewSpeed)
        {
            print("New speed: " + NewSpeed + " is faster then oldspeed");
        }
        else
        {
            print("New speed: " + NewSpeed + "= oldSpeed" +  oldSpeed );
        }
    }
}
