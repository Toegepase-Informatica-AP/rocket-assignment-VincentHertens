using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int minYPosition;
    public int maxYPosition;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = -2f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);

        if (transform.position.y < minYPosition || transform.position.y > maxYPosition)
        {
            speed *= -1f;
        }
    }
}
