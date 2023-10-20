using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
	public float timeToNextLevel = 2f; 

	private bool _levelCompleted = false;
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.attachedRigidbody.CompareTag("Player") && !_levelCompleted)
		{
			_levelCompleted = true;
			GameInstance.Instance.Win();
			StartCoroutine(NextLevelTimer());
		}
	}
	
	IEnumerator NextLevelTimer()
	{
		yield return new WaitForSeconds(timeToNextLevel);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
