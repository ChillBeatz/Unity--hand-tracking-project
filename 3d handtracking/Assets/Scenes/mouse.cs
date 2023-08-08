using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    // Start is called before the first frame update
    Collider collider;

    void Start()
    {
        collider = gameObject.GetComponent<Collider>();
        collider.enabled = false;
    }

    // Update is called once per frame
    Vector3 vect;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            vect = Input.mousePosition;
            vect.z = 10;
            gameObject.transform.position = Camera.main.ScreenToWorldPoint(vect);
        }
        if (Input.GetMouseButtonDown(0))
        {
            collider.enabled = true;

        }
        if (Input.GetMouseButtonUp(0))
        {
            collider.enabled = false;

        }
    }
    GameObject up, down;
    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "apple")
        {
            up = other.gameObject.transform.GetChild(0).gameObject;
            down = other.gameObject.transform.GetChild(1).gameObject;

            down.transform.parent = null;
            up.transform.parent = null;
            GameObject.Destroy(other.gameObject);

            down.GetComponent<Rigidbody>().isKinematic = false;
            up.GetComponent<Rigidbody>().isKinematic = false;

            down.GetComponent<Rigidbody>().AddRelativeForce(0,0,Random.Range(50,100));
            up.GetComponent<Rigidbody>().AddRelativeForce(0, 0,-Random.Range(50, 100));

        }
    }
}

