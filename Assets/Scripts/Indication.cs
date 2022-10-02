using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Indication : MonoBehaviour
{
    public static TextMeshProUGUI text;
    public int count;
    public static bool canIndicate;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        //text.faceColor = Color.white;
        count = 0;
        canIndicate = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && canIndicate)
        {
            text.faceColor = Color.green;
            canIndicate = false;   
        }

        if (count > 150)
        {
            count = 0;
            canIndicate = true;
            text.faceColor = Color.white;

        }

        if (canIndicate == false)
        {

            count += 1;
        }



        //Debug.Log(canIndicate);

    }
}
