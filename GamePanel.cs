using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePanel : MonoBehaviour
{
  
    public GameObject Panel1;

    public void meydanokumabolumler()
    {
        Application.LoadLevel(53);
    }
	public void ShowHidePanel(bool status)
	{
		Panel1.gameObject.SetActive(status);
	}

    
    public void PauseResumeGame()
	{
		bool durum = Time.timeScale == 0;
		ShowHidePanel (!durum);
		if (durum)  
		{
			Time.timeScale = 1;
		}
		else
		{
			Time.timeScale = 0;
		}
	} 
	public void RestartGame()
	{		
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);

		Time.timeScale = 1; 
        
	}
	public void Resume()
	{		
		Panel1.SetActive (false);
		Time.timeScale = 1; 
	}
	public void LevelıceLand()
	{
		Time.timeScale = 1; 
		SceneManager.LoadScene (2);
	}
	
	public void Menu()
	{
		Time.timeScale = 1; 
		SceneManager.LoadScene (1);
	}

}
