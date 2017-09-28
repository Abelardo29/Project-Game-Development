using UnityEngine;
using UnityEngine.EventSystems;

//made by Jan
public class ButtonMovement : MonoBehaviour {

    public EventSystem menuEvents;
    public GameObject defaultButton;

    private bool buttonSelected = false;

    // Update is called once per frame, checks for keyboard movement and selects the defaultButton if it finds anything.
	// Thats also why it's in a seperate file, so every menubutton doesn't run an update every frame. It only needs once per panel.
    void Update()
    {
        if (Input.GetAxisRaw("Vertical") != 0 && buttonSelected == false)
        {
			menuEvents.SetSelectedGameObject(defaultButton);
            buttonSelected = true;
        }
    }

	//Built in method to reset the buttonSelect.
    private void OnDisable()
    {
        buttonSelected = false;
    }
}