using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;
    public GameObject canvas;

    public void TriggerDialogue ()
	{
		
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	}

    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            Debug.Log("Ivoca Dialogo");
            canvas.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            Debug.Log("Acabou Dialogo");
            canvas.SetActive(false);
        }
    }

}

