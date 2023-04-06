using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGame : MonoBehaviour
{
    // Program zgaduje liczbe ktora wymyslilismy sobie z konkretnego przedzialu liczbowego.
    // Mamy przedzial od 1 do 1000 i program pyta czy wymyslona liczba jest wieksza lub mniejsza lub rowna  - np: 328
    //No i uzytkownik odpowiada wieksza lub mniejsza lub rowna
    // ALGORYTM -> Wyszukiwanie binarne ->

    int min = 1;
    int max = 1000;
    int shoot = 500;

    void Start()
    {
        //typ nazwe i ew. podac poczatkowa wartosc
        

        Debug.Log("Witaj w grze - pomysl w glowie liczbe od 1 do 1000");
        Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od 500?");
        //print string
        //Nacisnij gorna strzalke aby odpowiedziec ze wieksza
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od " + shoot + "?");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest rowna/wieksza/mniejsza od " + shoot + "?");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Komputer zgadl liczbe");
        }
    }
}
