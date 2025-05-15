using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ReconocerImagenAR : MonoBehaviour
{
    public ARTrackedImageManager trackedImageManager;
    public GameObject objetoPrefab;

    void OnEnable() => trackedImageManager.trackedImagesChanged += OnChanged;
    void OnDisable() => trackedImageManager.trackedImagesChanged -= OnChanged;

    void OnChanged(ARTrackedImagesChangedEventArgs e)
    {
        foreach (var image in e.added)
        {
            Instantiate(objetoPrefab, image.transform.position, image.transform.rotation);
        }
    }
}