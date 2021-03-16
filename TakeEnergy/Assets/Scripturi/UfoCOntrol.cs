//using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UfoCOntrol : MonoBehaviour
{    public float speed;
    public Text countText;
    public Text Castigat;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        Castigat.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Baterie"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();


        }
    }

    void SetCountText()
    {
        countText.text = "Scor: " + count.ToString();
        if(count>=10)
        {
            Castigat.text = "Full Energy!";
        }
    }
}