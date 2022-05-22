using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{ 
    public int birthday;
    public string firstName;
    public string lastName;

    // Start is called before the first frame update
    void Start()
    {
        print("Your name is: " + firstName + " " + lastName);
        print("Your initials are: " + firstName[0] + lastName[0]);
        print("The length of your full name is: " + (firstName + lastName).Length);

        int randomNumber = Random.Range(0, firstName.Length);
        print("Here is a random number from your first name " + firstName[randomNumber]);

        int age = 2022 - birthday;
        print("You were born in " + birthday.ToString() + "which means that you are " + age.ToString() + " years old");

        int day = age * 365;
        print("You have been alive for " + day.ToString() + " days");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
