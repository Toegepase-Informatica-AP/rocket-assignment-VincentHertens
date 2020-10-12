using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketGameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject scoreManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Rocket")
        {
            gameOverCanvas.SetActive(true);
            if (scoreManager != null)
            {
                scoreManager.SetActive(false);
            }
        }
    }
}
