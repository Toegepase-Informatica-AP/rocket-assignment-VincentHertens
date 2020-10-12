using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    [SerializeField] float boostForce = 10f;
    [SerializeField] float tiltingForce = 10f;
    //[SerializeField] float tiltingForce2 = 10f;

    bool thrust = false;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float tilt = Input.GetAxis("Horizontal");
        thrust = Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow);

        if (!Mathf.Approximately(tilt, 0f))
        {
            rb.freezeRotation = true;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + (new Vector3((tilt * tiltingForce * Time.deltaTime), 0f, 0f)));
        }
        rb.freezeRotation = false;
        //UserInput();
    }

    private void FixedUpdate()
    {
        if (thrust)
        {
            rb.AddRelativeForce(Vector3.up * boostForce * Time.deltaTime);
        }
    }
}
