using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// donkeyController, dras på eselet

public class donkeyController : MonoBehaviour
{
    // definere variabel for farta til eselet
    public float speed;

    // Start() kjøres med én gang skriptet lastes
    void Start()
    {
        // sette farta
        speed = 0.3F; 
    }

    void FixedUpdate()
    {
        // senk eselets Z-posisjon med "speed" hver frame (eslene går bakover)
        // ("transform" er eselets "transform" når skriptet settes på eselet)
        // (vi må lage en "new Vector3" for å skrive inn X, Y og Z-verdier)
        transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - speed);

        // er eselet ute av skjermbildet?
        if (transform.position.z < -6)
        {
            // fjern eselet fra scenen
            // ("gameObject" er eselet når skriptet settes på eselet)
            Destroy(gameObject);
        }
    }
}

// husk å kjøpe overnatting-på-reenskaug-til-jan-arild
