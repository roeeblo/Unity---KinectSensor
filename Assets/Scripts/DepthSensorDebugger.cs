using UnityEngine;
using Windows.Kinect;

public class DepthSensorDebugger : MonoBehaviour
{
	private KinectSensor _sensor;

	void Start()
	{
		_sensor = KinectSensor.GetDefault();

		if (_sensor != null)
		{
			var frameDesc = _sensor.DepthFrameSource.FrameDescription;

			Debug.Log("Width: " + frameDesc.Width);
			Debug.Log("Height: " + frameDesc.Height);
			Debug.Log("LengthInPixels: " + frameDesc.LengthInPixels);
		}
	}
}
