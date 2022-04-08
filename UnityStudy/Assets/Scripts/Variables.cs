using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Variables : MonoBehaviour
{
    public string name = "Lisa";
    public string weapon = "Wooden Sword";
    public int health = 10;
    public float speed = 5.5f;
    public int enemyDamage = 2;

        // Start is called before the first frame update
        void Start()
    {
        print("Welcome" + name);
        print("the enemy found you and you were too slow to run away from him because your speed is only " + speed.ToString());
        
        health -= enemyDamage;

        print("The enemy delt you " + enemyDamage.ToString() + "so you have got " + health.ToString() + " health left.");
        print("After much struggle, you were finally able to kill the enemy with your " + weapon);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
