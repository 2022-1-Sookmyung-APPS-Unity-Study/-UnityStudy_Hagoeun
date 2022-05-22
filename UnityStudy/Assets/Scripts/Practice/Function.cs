using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
    int health = 10;
    public int damageAmount;

    void TakeDamage(int damage) {
        health -= damage;
        print("Ouch! You took damage! You are now down to " + health);
    }

    bool IsAlive() {
        if (health <= 0)
        {
            return true;
        }
        else {
            return false;
        }
    }

    //int Add(int number1, int number2) {
    //    int result = number1 + number2;
    //    return result;
    //}

    //void WelcomePlayer(string playerName) {
    //    print("Welcome " + playerName);
    //    print("Good luck!");
    //}
    
    void Start()
    {
    //    WelcomePlayer("Sam");
    //    WelcomePlayer("Charlie");

    //    int functionResult = Add(5, 10);
    //    print(functionResult);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            TakeDamage(damageAmount);
            print("Player dead: " + IsAlive());
        }
    }
}
