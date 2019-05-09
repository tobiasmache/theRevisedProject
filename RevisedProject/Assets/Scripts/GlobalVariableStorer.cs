using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariableStorer : MonoBehaviour
{
    public static GlobalVariableStorer Instance;
    public int health=0;
    public int lightIntensity=7;
    public int SceneNumber=-1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
