using UnityEngine;

namespace UnityStandardAssets.Utility
{
	public class SmoothFollow : MonoBehaviour
	{

		// The target we are following
		[SerializeField]
		public Transform target;
		// The distance in the x-z plane to the target
		[SerializeField]
		private float distance = 10.0f;
		// the height we want the camera to be above the target
		[SerializeField]
		private float height = 5.0f;
        private float width = -5f;
        [SerializeField]
		private float rotationDamping;
		[SerializeField]
		private float heightDamping;
        private float widthDamping;

        // Use this for initialization
        void Start() { }

		// Update is called once per frame
		void LateUpdate()
		{
			// Early out if we don't have a target
			if (!target)
				return;

			// Calculate the current rotation angles
			var wantedRotationAngleY = target.eulerAngles.y;
            var wantedRotationAngleX = target.eulerAngles.x;
            var wantedHeight = target.position.y + height;
            var wantedWidth = target.position.x;

            var currentRotationAngleY = transform.eulerAngles.y;
            var currentRotationAngleX = transform.eulerAngles.x;
            var currentHeight = transform.position.y;
            var currentWidth = transform.position.x;

            // Damp the rotation around the y-axis
            currentRotationAngleY = Mathf.LerpAngle(currentRotationAngleY, wantedRotationAngleY, rotationDamping * Time.smoothDeltaTime);
            currentRotationAngleX = Mathf.LerpAngle(currentRotationAngleX, wantedRotationAngleX, Time.smoothDeltaTime);

            // Damp the height
            currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.smoothDeltaTime *4f);
            currentWidth = Mathf.Lerp(currentWidth, wantedWidth, Time.smoothDeltaTime*2f);

            // Convert the angle into a rotation
            var currentRotation = Quaternion.Euler(currentRotationAngleX, currentRotationAngleY, 0);

			// Set the position of the camera on the x-z plane to:
			// distance meters behind the target
			transform.position = target.position;
			transform.position -= currentRotation * Vector3.forward * distance;

			// Set the height of the camera
			transform.position = new Vector3(currentWidth ,currentHeight , transform.position.z);

			// Always look at the target
			//transform.LookAt(target);
		}
	}
}