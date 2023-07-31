using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    Vector3 vect;

    void Update()
    {
        vect = Input.mousePosition;
        vect.z = 10;
        gameObject.transform.position = Camera.main.ScreenToWorldPoint(vect);
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Destroy(other.gameObject);
    }
}
