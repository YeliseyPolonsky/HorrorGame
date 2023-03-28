using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LooseCanvas : MonoBehaviour
{
    public Manager manager;
    private PlayerController1 playerController;
    public GameObject prefab;
    
    public GameObject timePrefab;

    public void Loose()
    {
        manager.time = 0;
        manager.enabled = false;
            gameObject.SetActive(true);
       
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Instantiate(timePrefab);
        gameObject.SetActive(false);
        GameObject player = Instantiate(prefab);
        player.transform.position = FindAnyObjectByType<Spawn>().transform.position;
    }
}
