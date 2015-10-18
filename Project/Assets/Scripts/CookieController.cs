using UnityEngine;
using System.Collections;

public class CookieController : MonoBehaviour {

    public GameObject WinPanel;
    public GameObject LosePanel;
    public static int Cookies;

    void Start ()
    {
        Cookies = 0;
    }

	public void Controller (int ButtonID)
    {
        if (ButtonID == 0)
        {
            PublicView.CookieCount++;
            Cookies++;

            PublicView.GameStarted = true;
        }

        if (ButtonID == 1)
        {
            LosePanel.GetComponent<CanvasGroup>().alpha = 0;
            LosePanel.GetComponent<CanvasGroup>().interactable = false;
            LosePanel.GetComponent<CanvasGroup>().blocksRaycasts = false;

            Cookies = 0;
            PublicView.RestartGame = true;
        }

        if (ButtonID == 2)
        {
            WinPanel.GetComponent<CanvasGroup>().alpha = 0;
            WinPanel.GetComponent<CanvasGroup>().interactable = false;
            WinPanel.GetComponent<CanvasGroup>().blocksRaycasts = false;

            Cookies = 0;
            PublicView.RestartGame = true;
        }

    }
}
