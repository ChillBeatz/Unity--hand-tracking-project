using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginController : MonoBehaviour
{   
    int flag = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void GameStart()
    {   
        if(flag == 1)
        {
            Application.LoadLevel("SampleScene");
        }
    }
}
