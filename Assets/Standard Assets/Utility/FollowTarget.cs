using System;
using UnityEngine;


namespace UnityStandardAssets.Utility
{
    public class FollowTarget : MonoBehaviour
    {
        public Transform target;
        Transform start;
        public Vector3 offset = new Vector3(0f, 4f, 0f);


        private void LateUpdate()
        {
            //transform.position = target.position + offset;
            //transform.position += offset;
            start = transform;
            transform.position = Vector3.Lerp(start.position, target.position, Time.deltaTime) + offset;
        }
    }
}
