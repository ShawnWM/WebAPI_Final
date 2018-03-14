using UnityEngine;
using UnityEngine.UI;

public class MenuScreenController : MonoBehaviour
{
    public GameObject playerName;
    public Text playerNameText;
    public GameObject startButton;

    public void ButtonPress()
    {
        startButton.SetActive(false);
        playerName.SetActive(true);
    }

    public void StartGame()
	{
        PlayerPrefs.SetString("playerName", playerNameText.text);
        //Debug.Log(PlayerPrefs.GetString("playerName"));
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
}