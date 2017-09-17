using UnityEngine;
using UnityEngine.SceneManagement;

//made by Jan
public class MenuManager : MonoBehaviour {

	public GameObject currentPanel;

    //This little method can load in different scenes as neccesary.
    public void LoadSceneByIndex(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

	//how the code switches between panels.
    public void SwitchPanel(GameObject newPanel)
    {
		currentPanel.SetActive(false);
        newPanel.SetActive(true);
    }

	//code on hitting the quit button, note that it reacts differently depending on what you use.
    public void Quit()
    {
#if UNITY_EDITOR //if the user is using the editor, we just stop using the editor aplication.
        UnityEditor.EditorApplication.isPlaying = false;
#else //if we're not using the Unity editor, just quit the aplication. Also note that this under here is greyed out, because this is being viewed through the Unity editor!
        Application.Quit();
#endif
    }
}