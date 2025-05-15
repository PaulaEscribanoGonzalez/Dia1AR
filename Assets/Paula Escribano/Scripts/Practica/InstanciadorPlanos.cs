using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;

public class InstanciadorPlanos : MonoBehaviour
{
    public GameObject prefabAInstanciar;
    public ARRaycastManager raycastManager;

    void Update()
    {
        if (Input.touchCount == 0) return;

        Touch touch = Input.GetTouch(0);
        if (touch.phase != TouchPhase.Began) return;

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        if (raycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
        {
            Pose hitPose = hits[0].pose;
            Instantiate(prefabAInstanciar, hitPose.position, hitPose.rotation);
        }
    }
}
