using UnityEngine;
using UnityEngine.SceneManagement;

public class ZonaDetector : MonoBehaviour
{
    public GameObject uiPanel;  // Panel con botón
    public string nombreEscena; // Nombre de la escena a cargar

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
            uiPanel.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
            uiPanel.SetActive(false);
    }

    public void CambiarEscena()
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
