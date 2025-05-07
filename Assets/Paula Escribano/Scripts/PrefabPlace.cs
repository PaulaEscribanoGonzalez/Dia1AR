using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;

public class PrefabPlace : MonoBehaviour
{
    public ARRaycastManager raycastManager;
    public List<GameObject> prefabOptions;
    public int selectedPrefabIndex = 0;

    private List<GameObject> spawnedPrefabs = new List<GameObject>();
    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            var touch = Input.GetTouch(0);
            if (raycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
            {
                Pose hitPose = hits[0].pose;
                GameObject prefab = Instantiate(prefabOptions[selectedPrefabIndex], hitPose.position, hitPose.rotation);
                spawnedPrefabs.Add(prefab);
            }
        }
    }

    public void SetSelectedPrefabIndex(int index)
    {
        selectedPrefabIndex = index;
    }

    public void ClearAllPrefabs()
    {
        foreach (var obj in spawnedPrefabs)
        {
            Destroy(obj);
        }
        spawnedPrefabs.Clear();
    }
}
