using UnityEngine;
using System.Collections;

public class MineGestureListener : MonoBehaviour, KinectGestures.GestureListenerInterface {

	public void UserDetected(uint userId, int userIndex)
	{
		// as an example - detect these user specific gestures
		KinectManager manager = KinectManager.Instance;

		//		manager.DetectGesture(userId, KinectGestures.Gestures.Push);
		//		manager.DetectGesture(userId, KinectGestures.Gestures.Pull);
		
		//manager.DetectGesture(userId, KinectGestures.Gestures.SwipeLeft);
		//manager.DetectGesture(userId, KinectGestures.Gestures.SwipeRight);

	}
	
	public void UserLost(uint userId, int userIndex)
	{
	}
	
	public void GestureInProgress(uint userId, int userIndex, KinectGestures.Gestures gesture, 
	                              float progress, KinectWrapper.NuiSkeletonPositionIndex joint, Vector3 screenPos)
	{
		if (gesture == KinectGestures.Gestures.SwipeLeft)
		{
			//Debug.Log("SwipeLeft " + progress + " Screen Pos: "+ screenPos + " Gesture: " + gesture);
		}
		if (gesture == KinectGestures.Gestures.SwipeRight)
		{
			//Debug.Log("SwipeRight " + progress + " Screen Pos: "+ screenPos + " Gesture: " + gesture);
		}

	}
	
	public bool GestureCompleted (uint userId, int userIndex, KinectGestures.Gestures gesture, 
	                              KinectWrapper.NuiSkeletonPositionIndex joint, Vector3 screenPos)
	{
		return true;
	}
	
	public bool GestureCancelled (uint userId, int userIndex, KinectGestures.Gestures gesture, 
	                              KinectWrapper.NuiSkeletonPositionIndex joint)
	{

		return true;
	}
}
