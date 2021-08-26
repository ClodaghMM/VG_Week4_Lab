using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 3;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //increment i
        ++i;
        Debug.Log(gameObject.name +  ":" + i);
        
        int rInt = Random.Range(0, 251);

        if (gameObject.tag == 
        "Red" && i == 100) 
        {
            gameObject.SetActive(false);
        }

        if (gameObject.tag == "Blue" && rInt > 200 && rInt < 251)
        {
            rend = gameObject.GetComponent<Renderer>();
            rend.enabled = false;
        } 

    }
}
