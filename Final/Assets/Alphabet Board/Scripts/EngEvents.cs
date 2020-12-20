using UnityEngine;
using System.Collections;

/// Implement your game events in this script
public class EngEvents : MonoBehaviour
{
		private EngWritingHandler writingHandler;

		void Start ()
		{
				//Setting up the writingHandler reference
				GameObject letters = HierrachyManager.FindActiveGameObjectWithName ("Letters");
				if (letters != null)
						writingHandler = letters.GetComponent<EngWritingHandler> ();
		}

		//Load the next letter
		public void LoadTheNextLetter (object ob)
		{
				if (writingHandler == null) {
						return;
				}
				writingHandler.LoadNextLetter ();
		}

		//Load the previous letter
		public void LoadThePreviousLetter (object ob)
		{
				if (writingHandler == null) {
						return;
				}
				writingHandler.LoadPreviousLetter ();

		}

		//Load the current letter
		public void LoadLetter (Object ob)
		{
				if (ob == null) {
						return;
				}
				EngWritingHandler.currentLetterIndex = int.Parse (ob.name.Split ('-') [1]);
				Application.LoadLevel ("EngAlphabetWriting");
		}
	
		//Erase the current letter
		public void EraseLetter (Object ob)
		{
				if (writingHandler == null) {
						return;
				}
				writingHandler.RefreshProcess ();

		}

	//Load alphabet menu
	public void LoadAlphabetMenu(Object ob){
		Application.LoadLevel ("EngAlphabetMenu");
	}
}