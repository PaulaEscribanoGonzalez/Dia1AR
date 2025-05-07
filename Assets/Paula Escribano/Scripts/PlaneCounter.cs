using UnityEngine;
using TMPro; // Importante para usar TextMeshProUGUI
using UnityEngine.XR.ARFoundation;

public class PlaneCounter : MonoBehaviour
{
    public ARPlaneManager planeManager;
    public TextMeshProUGUI planeCountText;

    void Update()
    {
        if (planeManager != null && planeCountText != null)
        {
            int planeCount = planeManager.trackables.count;
            planeCountText.text = "Planos detectados: " + planeCount;
        }
    }
}
