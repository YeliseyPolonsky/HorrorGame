using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour
{

    public Manager gameController;

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Manager>())
        {
            gameController.CompleteLevel();
        }
    }
}
