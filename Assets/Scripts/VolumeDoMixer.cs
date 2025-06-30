using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeDoMixer : MonoBehaviour
{
	[SerializeField]
	private AudioMixer mixer;
	[SerializeField]
	private string parametroDoMixer;
	[SerializeField]
	private Slider slider;

	private void Start()
	{
		if (PlayerPrefs.HasKey(parametroDoMixer))
		{
			float volume = PlayerPrefs.GetFloat(parametroDoMixer);
			mixer.SetFloat(parametroDoMixer, volume);
			slider.value = volume;
		}
		else
		{
			mixer.GetFloat(parametroDoMixer, out float defaultValue);
			slider.value = defaultValue;
			//mixer.SetFloat(parametroDoMixer, 0);
		}
	}

	public void MudarVolume(float volume)
	{
		mixer.SetFloat(parametroDoMixer, volume);
		PlayerPrefs.SetFloat(parametroDoMixer, volume);
	}
}
