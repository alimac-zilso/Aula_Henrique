using UnityEngine;
using UnityEngine.InputSystem;
public class DiagnosticoJogador : MonoBehaviour {
    
    [SerializeField] private Color corAlerta = Color.red;
    private SpriteRenderer sprite;
    void Awake() { sprite = GetComponent<SpriteRenderer>(); }
    void Update() {
        if (Keyboard.current.cKey.wasPressedThisFrame) {
            sprite.color = corAlerta;
            Debug.Log("Cor do jogador alterada");
        }
        if (Keyboard.current.pKey.wasPressedThisFrame) {
            Debug.Log($"Posição: {transform.position}");
        }
    }
}
