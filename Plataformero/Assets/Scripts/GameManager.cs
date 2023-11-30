using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float x;
    public static float y;
    // Start is called before the first frame update
    void Start()
    {
        if(x!=0)
        {
            GameObject elPerso = GameObject.FindGameObjectWithTag("Player");
            elPerso.transform.position = new Vector2(x, y);

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
