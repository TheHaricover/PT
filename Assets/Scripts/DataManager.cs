using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public List<string> Actions = new List<string>();
    
    void Awake(){
        for (int i = 0; i<15; i++){
            Actions.Add ("Action" + i.ToString());
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
