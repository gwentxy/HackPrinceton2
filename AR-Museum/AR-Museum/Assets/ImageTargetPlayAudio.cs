using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ImageTargetPlayAudio : MonoBehaviour,
ITrackableEventHandler
{
	private TrackableBehaviour mTrackableBehaviour;
	public Animation animation1;
	public AudioClip MusicClip;
	public AudioSource MusicSource;
	public GameObject head;
	public GameObject body;
	public GameObject leftArm;
	public GameObject rightArm;
	public GameObject leftLeg;
	public GameObject rightLeg;

	void Start()
	{
		MusicSource.clip = MusicClip;
		TrackableBehaviour mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		Animation animation1 = GetComponent<Animation>();

		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			// Play audio when target is found
			MusicSource.Play();
			head.SetActive(true);
			body.SetActive(true);
			leftArm.SetActive(true);
			rightArm.SetActive(true);
			leftLeg.SetActive(true);
			rightLeg.SetActive(true);

			if (!MusicSource) {
				animation1.Stop();
			}
		}
		else
		{
			// Stop audio when target is lost
			MusicSource.Stop();
			head.SetActive(false);
			body.SetActive(false);
			leftArm.SetActive(false);
			rightArm.SetActive(false);
			leftLeg.SetActive(false);
			rightLeg.SetActive(false);
		}
			
	}   
}