﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHearts : MonoBehaviour
{
    public Sprite Heart_on;
    public Sprite Heart_off;
    SpriteRenderer[] spriteRenders;

    public void CreateHearts(GameObject h1, GameObject h2, GameObject h3)
    {
        spriteRenders = new SpriteRenderer[3];
        spriteRenders[0] = h1.gameObject.GetComponent<SpriteRenderer>();
        spriteRenders[1] = h2.gameObject.GetComponent<SpriteRenderer>();
        spriteRenders[2] = h3.gameObject.GetComponent<SpriteRenderer>();
        Debug.Log("Finished");

    }

    public void UpdateHearts(int health)
    {
        Debug.Log("Update Hearts: " + health);
        if (health != 0)
        {
            spriteRenders[health - 1].sprite = Heart_off;
        }
    }


    // Start is called before the first frame update
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}

