// Script for having a typewriter effect for UI
// Prepared by Nick Hwang (https://www.youtube.com/nickhwang)
// Yes, I willingly saved the text above 

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IntroTextScript : MonoBehaviour
{
	Text text;
	TMP_Text tmpProText;
	string writer;

	[SerializeField] float delayBeforeStart = 0f;
	[SerializeField] float timeBtwChars = 0.1f;
	[SerializeField] string leadingChar = "";
	[SerializeField] bool leadingCharBeforeDelay = false;

	// Use this for initialization
	void Start()
	{
		text = GetComponent<Text>()!;
		tmpProText = GetComponent<TMP_Text>()!;

		if(text != null)
        {
			writer = text.text;
			text.text = "";

			StartCoroutine(nameof(TypeWriterText));
		}

		if (tmpProText != null)
		{
			writer = tmpProText.text;
			tmpProText.text = "";

			StartCoroutine(nameof(TypeWriterTMP));
		}
	}

	IEnumerator TypeWriterText()
	{
		text.text = leadingCharBeforeDelay ? leadingChar : "";

		yield return new WaitForSeconds(delayBeforeStart);

		foreach (char c in writer)
		{
			if (text.text.Length > 0)
			{
				text.text = text.text.Substring(0, text.text.Length - leadingChar.Length);
			}
			text.text += c;
			text.text += leadingChar;
			yield return new WaitForSeconds(timeBtwChars);
		}

		if(leadingChar != "")
        {
			text.text = text.text.Substring(0, text.text.Length - leadingChar.Length);
		}
	}

	IEnumerator TypeWriterTMP()
    {
        tmpProText.text = leadingCharBeforeDelay ? leadingChar : "";

        yield return new WaitForSeconds(delayBeforeStart);

		foreach (char c in writer)
		{
			if (tmpProText.text.Length > 0)
			{
				tmpProText.text = tmpProText.text.Substring(0, tmpProText.text.Length - leadingChar.Length);
			}
			tmpProText.text += c;
			tmpProText.text += leadingChar;
			yield return new WaitForSeconds(timeBtwChars);
		}

		if (leadingChar != "")
		{
			tmpProText.text = tmpProText.text.Substring(0, tmpProText.text.Length - leadingChar.Length);
		}
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			timeBtwChars = 0.0001f;
		}
	}
}