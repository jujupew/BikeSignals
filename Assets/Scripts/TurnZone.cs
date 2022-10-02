using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            BikeController bike = other.GetComponent<BikeController>();
            bike.canTurn = true;

        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        BikeController bike = other.GetComponent<BikeController>();
        bike.canTurn = false;

    }
}
