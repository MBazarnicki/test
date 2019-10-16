using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int min = 1;
        int max = 1000;
        int guess = 500;
    


        {
            print("Witaj u Liczbowego Czarodzieja");
            print("Pomysl o jakiejs liczbie, ale nie mow jej na glos");

            print("Największa liczna jaka możesz wybrać to" + max);
            print("Najmniejsza liczba jaka mozesz wybrac to" + min);
            print("Czy twoja liczba jest mniejsza czy wieksza od 500");
            print("Aby odpowiedzieć na pytanie nacisnij: Gorna strzalka = wyzsza Dolna strzalka = nizsza Enter=Równa");


        }
    
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                min = guess;
                guess = (min + max) / 2;
                print("Czy twoja liczba jest mniejsza czy wieksza od" + guess);
                print("Gorna strzalka zostala nacisnieta");
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                max = guess;
                guess = (min + max) / 2;
                print("Czy twoja liczba jest mniejsza czy wieksza od" + guess);
                print("Dolna strzalka zostala nacisnienta");
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {

                print("Haha zgadłem twoją liczbę");
            }
        }


    
}