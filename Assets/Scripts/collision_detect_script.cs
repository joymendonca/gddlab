using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_detect_script : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;
    float speed = 5;
    int coin = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Renderer>().material.color == Color.red)
        {
            coin = coin + 1;
            print("Coins: " + coin);
        }
        else
        {
            coin = coin - 1;
            print("Coins: " + coin);
        }
    }
}
