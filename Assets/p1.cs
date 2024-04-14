using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1 : MonoBehaviour
{
    public float moveSpeed = 5f; // Declare and initialize moveSpeed

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool isPressingUp = Input.GetKey(KeyCode.W);
        bool isPressingDown = Input.GetKey(KeyCode.S);

        if (isPressingUp)
        {
            transform.Translate(Vector3.up * Time.deltaTime * moveSpeed); // Corrected Vector3.up
        }

        if (isPressingDown)
        {
            transform.Translate(Vector3.down * Time.deltaTime * moveSpeed); // Corrected Vector3.down
        }
    }
}
