using UnityEngine;
using UnityEngine.UI;


public class scoreboard : MonoBehaviour
{

    public Text scoreText;
    public static int scoreCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
    }
}
