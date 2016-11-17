using UnityEngine;
using System.Collections;

public class PauseMenuScript : MonoBehaviour 
{
    // Public GameObjects to set buttons
    public GameObject continueButton;
    public GameObject restartButton;
    public GameObject mainMenuButton;
    public GameObject exitButton;
    public GameObject pauseButton;

    // Pauses the game and shows the menu
    public void Pause()
    {
       Time.timeScale = 0;
        
       continueButton.SetActive(true);
       restartButton.SetActive(true);
       mainMenuButton.SetActive(true);
       exitButton.SetActive(true);
       pauseButton.SetActive(false);
    }                  


    // If continue button is clicked it will unpause the level.
    // It will enable pause button render and disable the other buttons as well as itself
    // resume animation
    public void ContinueGame()
    {
        Time.timeScale = 1;

        continueButton.SetActive(false);
        restartButton.SetActive(false);
        mainMenuButton.SetActive(false);
        exitButton.SetActive(false);
        pauseButton.SetActive(true);
    }


	// If restart button is clicked it will restart the level.
    // It will enable pause button render and disable the other buttons as well as itself
	public void Restart()
    {
        var lastLvl = Application.loadedLevel;
        Application.LoadLevel(lastLvl);
        Time.timeScale = 1;
    }


	// If main menu button is clicked it will load the main menu
	public void MainMenu()
    {
        Application.LoadLevel(0);
        Time.timeScale = 1;
    }


	///Summary
	// If exit game is clicked then the game will exit
	/// Summary end

	public void Exit()
    {
        Application.Quit();
	}
}
