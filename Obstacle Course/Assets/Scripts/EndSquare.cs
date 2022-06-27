using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSquare : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            Debug.Log("You win!");
        }

    }
}
