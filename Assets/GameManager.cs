using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    //public static GameManager instance;
    //public Text scoreText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private int score = 0;
    
    /*void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }*/

    public void incrementScore()
    {
        score ++;
        scoreText.text = $"Score: {score}";


    }
}
