using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class First : MonoBehaviour
{
    public TextMeshProUGUI text;
    private Manager manager;

    void Start()
    {
        manager = FindAnyObjectByType<Manager>();
        text.text = $"Выберитесь из лабиринта за {manager.maxTime}";
        StartCoroutine( ShowText());
    }

    private IEnumerator ShowText()
    {
        yield return new WaitForSeconds(2.5f);
        gameObject.SetActive(false);
    }    
}
