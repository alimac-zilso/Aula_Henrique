using UnityEngine;
using UnityEngine.InputSystem;
public class CameraInspecao : MonoBehaviour 
{
    [SerializeField] private float velocidade = 5f;
    private InputAction mover;
    void Awake() {
        mover = InputSystem.actions.FindAction("Move");
    }
    void Update() {
        Vector2 direcao = mover.ReadValue<Vector2>();
        Vector3 passo = direcao * velocidade * Time.deltaTime;
        transform.position += passo;
    }
}
