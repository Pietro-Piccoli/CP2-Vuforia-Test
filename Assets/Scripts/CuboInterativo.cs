using UnityEngine;
using UnityEngine.InputSystem;

// Gira o cubo conforme o usuario arrasta o dedo (celular) ou o mouse (editor).
// Anexado ao cubo que aparece sobre o Image Target no Vuforia.
public class CuboInterativo : MonoBehaviour
{
    [Tooltip("Velocidade da rotacao ao arrastar.")]
    [SerializeField] private float velocidadeRotacao = 0.2f;

    private Vector2 posicaoAnterior;
    private bool arrastando;

    void Update()
    {
        // Toque na tela (build no celular)
        if (Touchscreen.current != null && Touchscreen.current.primaryTouch.press.isPressed)
        {
            Vector2 pos = Touchscreen.current.primaryTouch.position.ReadValue();
            AtualizarRotacao(pos);
            return;
        }

        // Mouse (teste no Editor com a webcam)
        Mouse mouse = Mouse.current;
        if (mouse != null && mouse.leftButton.isPressed)
        {
            AtualizarRotacao(mouse.position.ReadValue());
        }
        else
        {
            arrastando = false;
        }
    }

    private void AtualizarRotacao(Vector2 posicaoAtual)
    {
        if (!arrastando)
        {
            posicaoAnterior = posicaoAtual;
            arrastando = true;
            return;
        }

        Vector2 delta = posicaoAtual - posicaoAnterior;

        // arrastar na horizontal gira em Y, na vertical gira em X
        transform.Rotate(Vector3.up, -delta.x * velocidadeRotacao, Space.World);
        transform.Rotate(Vector3.right, delta.y * velocidadeRotacao, Space.World);

        posicaoAnterior = posicaoAtual;
    }
}
