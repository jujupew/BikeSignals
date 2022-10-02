using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ticketCounterScript : MonoBehaviour
{
    public GameObject NumTickets;
    public int tickets1;
    public TMP_Text text;
    public TextMeshProUGUI text1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BikeController bike= NumTickets.GetComponent<BikeController>();
        tickets1 = bike.tickets;
        text1.text = tickets1.ToString("D4");

    }
}
