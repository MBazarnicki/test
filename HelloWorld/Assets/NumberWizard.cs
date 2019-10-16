using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Witaj u Liczbowego Czarodzieja");
        print("Pomysl o jakiejs liczbie, ale nie mow jej na glos");
        int min = 1;
        int max = 1000;
        print("Największa liczna jaka możesz wybrać to" + max);
        print("Najmniejsza liczba jaka mozesz wybrac to" + min);
        print("Czy twoja liczba jest mniejsza czy wieksza od 500");
        print("Aby odpowiedzieć na pytanie nacisnij: Gorna strzalka = wyzsza Dolna strzalka + nizsza");
        if (Input.GetKeyDown(KeyCode.UpArrow))
        { print("Gorna strzalka zostala nacisnieta");| }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        { pirnt("Dolna strzalka zostala nacisnienta"); }
        if (Input.GetKeyDown(KeyCode.Return))
        { print("Enter zostal nacisniety"); }

       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
