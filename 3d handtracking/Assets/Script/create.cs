using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject apple;
    GameObject objcopy;
    void Start()
    {
        
    }
    float n;
    // Update is called once per frame
    void Update()
    {
        n = n + Time.deltaTime;
        if (n > 0.5f)
        {
            copy();
            n = 0;
        }
    }

    void copy()
    {
           objcopy = GameObject.Instantiate(apple);
            objcopy.transform.position = new Vector3(Random.Range(-7, 7f), -6, 0);
            objcopy.SetActive(true);

            Rigidbody rig;
            rig = objcopy.GetComponent<Rigidbody>();
            rig.AddForce(Random.Range(-100, 100), Random.Range(500, 750), 0);
            rig.AddTorque(Random.Range(-50, 50), Random.Range(-50, 50), Random.Range(-50, 50));
    }
}