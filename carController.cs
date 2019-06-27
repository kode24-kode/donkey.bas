using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// carController, dras på bilen

public class carController : MonoBehaviour
{
    // variablene for bilstyring
    public bool isTurned;
    public float positionA;
    public float positionB;

    void Update()
    {
        // trykkes space ned?
        if (Input.GetKeyDown("space"))
        {
            // snu bilen i teorien
            isTurned = !isTurned;

            // snu bilen i praksis
            if (isTurned)
            {
                // sett X-posisjon til positionA, uten å endre Y- og Z-posisjoner
                transform.position = new Vector3(positionA, transform.position.y, transform.position.z);
            }

            else
            {
                // sett X-posisjon til positionB, uten å endre Y- og Z-posisjoner
                transform.position = new Vector3(positionB, transform.position.y, transform.position.z);
            }
        }
    }

    // kjører når bilen kolliderer med esel
    private void OnTriggerEnter()
    {
        GameObject.Find("Game").GetComponent<gameController>().gameOver = true;
    }
}
