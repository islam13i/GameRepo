using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;
	public float restartDelay = 1f;
	public void EndGame(){
		gameHasEnded = true;
		Debug.Log ("Game Over");
		Invoke ("Restart",2f);
	} 
	public void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}
}
