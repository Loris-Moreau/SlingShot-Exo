using UnityEngine;
using UnityEngine.UI;

public class Rewards : MonoBehaviour
{
    public GameObject InstructionsText;
    public GameObject MissionText;
    public GameObject WinText;

    //scores
    public static int CurrentScore;
    public int InternalScore;    
    public GameObject ScoreDisplay;
    public AudioClip WinSound;

    void Start()
    {
        InstructionsText.SetActive(true);
        MissionText.SetActive(true);

        WinText.SetActive(false);

        ScoreDisplay.SetActive(true);
    }

    void Update()
    {
		/*if(all enemies dead) //Win Condition
        {
            InstructionsText.SetActive(false);
            MissionText.SetActive(false);
            
            WinTextSetActive(true);
            
            AudioSource.PlayClipAtPoint(WinSound, transform.position);  
        }*/

		InternalScore = CurrentScore;
        ScoreDisplay.GetComponent<Text>().text = "score : " + InternalScore + "  ";
	}
}
