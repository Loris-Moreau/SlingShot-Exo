using StarterAssets;
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
        InternalScore = CurrentScore;

        ScoreDisplay.GetComponent<Text>().text = "score : " + InternalScore + "  ";
	}

    public void Won()
    {
		InstructionsText.SetActive(false);
		MissionText.SetActive(false);

		WinText.SetActive(true);

		AudioSource.PlayClipAtPoint(WinSound, transform.position);
	}
}
