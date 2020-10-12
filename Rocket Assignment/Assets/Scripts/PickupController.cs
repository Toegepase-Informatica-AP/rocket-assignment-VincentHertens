using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    public GameObject pickUpItem;
    public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        if (pickUpItem == null)
        {
            pickUpItem = transform.gameObject;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        scoreManager.IncreaseScore(1);
    }
}
