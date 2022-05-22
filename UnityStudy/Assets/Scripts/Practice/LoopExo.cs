using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopExo : MonoBehaviour
{

    int i = -5;
    int p = 10;
    int k = 1;

    // Start is called before the first frame update
    void Start()
    {
        while (i <= 5) {
            print(i);
            i += 1;
        }

        //for (int i = -5; i <= 5; i += 1) {
        //    print(i);
        //}

        while (p <= 50) {
            print(p);
            p += 2;
        }

        //for (int p = 10; p <= 50; p += 2){
        // print(p);
        //}

        while (k <= 100) {
            if (k % 5 == 0 && k % 3 == 0)
            {
                print(k);
            }
            k += 1;
        }

        //for (int k = 1; k <= 100; k += 1) {
        //    if (k % 5 == 0 && k % 3 == 0)
        //    {
        //        print(k);
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
