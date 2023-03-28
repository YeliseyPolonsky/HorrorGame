using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class Manager : MonoBehaviour
{
    public LooseCanvas looseCanvas;
    public TextMeshProUGUI timerText;
    public Text attemptsText;
    public GameObject exit;
    public int maxTime;
    public PlayerController1 PlayerController1;
    public bool IsLoose = false;
    public float time;
    public GameObject timeGM;
    public GameObject WinForm;
    public AudioSource _vadim;

    private int attempts = 0;
    private float startTime;
    private bool gameFinished = false;

    void Start()
    {
        startTime = Time.time;
        UpdateTimer();
        UpdateAttempts();
    }

    void Update()
    {
        if (!gameFinished)
        {
            UpdateTimer();
        }
        if (maxTime == int.Parse(timerText.text))
        {
            IsLoose = true;
        }
    }

    void UpdateTimer()
    {        
        time = Time.time - startTime;
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        timerText.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
        Debug.Log(time);
        Debug.Log(maxTime);
        if (maxTime <= time)
        {
            
            time = 0;
            looseCanvas.Loose();           
        }
    }

    void UpdateAttempts()
    {
        attemptsText.text = "Attempts: " + attempts + "/" + maxTime;
    }

    public void CompleteLevel()
    {
        WinForm.SetActive(true);
        gameObject.GetComponent<AudioSource>().enabled = false;
        gameFinished = true;
        exit.SetActive(true);
        int timeScore = Mathf.FloorToInt(Time.time - startTime);
        int attemptsScore = maxTime - attempts;
    }
}
