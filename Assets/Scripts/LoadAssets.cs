using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{

    public GameObject redObj;
    [SerializeField] private GameObject blueObj;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(redObj,new Vector3(2.0F,0.0F,0.0F), Quaternion.identity);

        Instantiate(blueObj,new Vector3(-2.0F,0.0F,0.0F), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
