using UnityEngine;

public class MovimientoEditor : MonoBehaviour
{
    public float velocidadMovimiento = 3f;
    public float velocidadRotacion = 100f;

    void Update()
    {
        // Movimiento con W/S
        float mover = Input.GetAxis("Vertical") * velocidadMovimiento * Time.deltaTime;
        transform.Translate(0, 0, mover);

        // Rotación con A/D
        float rotar = Input.GetAxis("Horizontal") * velocidadRotacion * Time.deltaTime;
        transform.Rotate(0, rotar, 0);
    }
}
