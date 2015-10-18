using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PublicView : MonoBehaviour {
    
    public static int CookieCount;
    public Text CookieCountUI;
    public Text CookieTimerUI;
    public Text NeedCookiesUI;

    public float CookieTimer;
    public int CookieTime;

    public static bool GameStarted;
    public static bool RestartGame;

    public GameObject WinPanel;
    public GameObject LosePanel;

    // Use this for initialization
	void Start () {

        CookieCount = 0;
        CookieTime = 25;
	}
	
	// Update is called once per frame
	void Update () {

        if (RestartGame == true)
        {
            CookieCount = 0;
            CookieTime = 25;

            GameStarted = false;
            RestartGame = false;
        }

        NeedCookiesUI.text = "" + CookieController.Cookies + " of 125";

        if (GameStarted == true)
        {

            CookieTimer += Time.deltaTime;

            if (CookieTimer >= 1f)
            {

                CookieTime--;
                CookieTimer = 0;
            }
        }

        CookieCountUI.text = CookieCount.ToString();
        CookieTimerUI.text = CookieTime.ToString();
	    
        if (CookieCount >= 125 && CookieTime >= 0)
        {
            // Win
            Application.OpenURL("https://akk.li/pics/anne/jpg");
            WinPanel.GetComponent<CanvasGroup>().alpha = 1;
            WinPanel.GetComponent<CanvasGroup>().interactable = true;
            WinPanel.GetComponent<CanvasGroup>().blocksRaycasts = true;
        }

        if (CookieCount != 125 && CookieTime <= 0)
        {

            LosePanel.GetComponent<CanvasGroup>().alpha = 1;
            LosePanel.GetComponent<CanvasGroup>().interactable = true;
            LosePanel.GetComponent<CanvasGroup>().blocksRaycasts = true;
        }

	}
}
