using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class MenuInicial : MonoBehaviour
{
    public TMP_InputField ambienteInput;
    public Button iniciarButton;

    private void Start()
    {
        iniciarButton.onClick.AddListener(IniciarJogo);
    }

    private void IniciarJogo()
    {
        string nomeAmbiente = ambienteInput.text;

        // Verifica se o nome do ambiente foi digitado
        if (!string.IsNullOrEmpty(nomeAmbiente))
        {
            // Armazena o nome do ambiente em um objeto de dados ou gerenciador de jogo, se necessário
            GameManager.Instance.SetNomeAmbiente(nomeAmbiente);// Exemplo:

            // Carrega a cena de seleção da construção
            SceneManager.LoadScene("Building");
        }
        else
        {
            Debug.Log("Digite um nome de ambiente válido!");
        }
    }
}
