using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroText : MonoBehaviour
{

    public string[] dialouge;
    int counter = 0;
    public Text talking;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("z") && counter<=6)
        {
            counter++;
            talking.text = dialouge[counter];
        }

    }




}
