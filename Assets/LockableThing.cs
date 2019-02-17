using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockableThing : MonoBehaviour
{
	public Text lockableThing;

	public void Unlock()
	{
		lockableThing.text = "Lockable thing is unlocked!";
	}
}
