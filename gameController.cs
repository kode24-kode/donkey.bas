using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// gameController, dras på "Game"

public class gameController : MonoBehaviour
{
    // alle variablene vi trenger
    public GameObject Donkey;
    public float positionA;
    public float positionB;
    public int points;
    public bool gameOver;

    // kjører med en gang spillet lastes
    void Start()
    {
        // få posisjonene vi trenger til eslene fra bilens skript
        positionA = GameObject.Find("Car").GetComponent<carController>().positionA;
        positionB = GameObject.Find("Car").GetComponent<carController>().positionB;

        // kjør PlaceDonkey() hvert halvte sekund
        InvokeRepeating("PlaceDonkey", 0.5f, 0.5f);
    }

    // plassere esler tilfeldig på veien
    void PlaceDonkey()
    {
        // er spillet fortsatt i gang?
        if (!gameOver)
        {
            // få tallet 1 eller 0
            int oneOrZero = Random.Range(0, 2);

            // plassere esel på posisjon A eller B om 1 eller 0
            if (oneOrZero == 0)
            {
                Instantiate(Donkey, new Vector3(positionA, -0.3f, 9), Quaternion.Euler(0, -180, 0));
            }

            else
            {
                Instantiate(Donkey, new Vector3(positionB, -0.3f, 9), Quaternion.Euler(0, -180, 0));
            }

            // gi poeng, og vis i GUI
            points++;
            GameObject.Find("Text").GetComponent<Text>().text = "<b>poeng:</b> " + points;
        }

        else
        {
            GameObject.Find("Text").GetComponent<Text>().text = "Game over! Du fikk " + points + " poeng.";
        }
    }
}
