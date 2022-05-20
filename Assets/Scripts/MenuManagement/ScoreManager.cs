using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI health;
    public TextMeshProUGUI score;
    [SerializeField] GameObject endMenu;
 public static ScoreManager instance;
    private void Awake()
    {
        if(instance == null)
            instance = this;
        if(instance!=null)
        {
            return;
        }
    }
    // Update is called once per frame
    void Update()
    {
        EndMenuActive();
        if (Player.playerHealth < 0)
        {
            health.text = "0";
        }
        else { health.text = Player.playerHealth.ToString(); }
        score.text = "Score "+"\n"+Player.playerScore.ToString();
    }
    public void EndMenuActive()
    {
        if (Player.playerHealth <= 0)
        {
            endMenu.SetActive(true);
            
        }
       
    }
}
