using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveThings : MonoBehaviour
{
	public Text text;
	public LockableThing lockableThing;
	int thingsGiven;

	void Start()
	{
		thingsGiven = 0;
	}

	void Update()
	{

		if (Input.GetKeyDown(KeyCode.Space))
		{
			thingsGiven++;
			text.text = string.Format("Things given: {0}", thingsGiven);
			if (thingsGiven >= 20)
			{
				lockableThing.Unlock();
			}
		}
	}
}