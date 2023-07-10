using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelecaoConstrucao : MonoBehaviour
{
    public Button construcao1Button;
    public Button construcao2Button;
    public Button construcao3Button;

    private int construcaoSelecionada;

    private void Start()
    {
        construcao1Button.onClick.AddListener(() => SelecionarConstrucao(1));
        construcao2Button.onClick.AddListener(() => SelecionarConstrucao(2));
        construcao3Button.onClick.AddListener(() => SelecionarConstrucao(3));
    }

    private void SelecionarConstrucao(int construcao)
    {
        construcaoSelecionada = construcao;

        // Armazena a construção selecionada em um objeto de dados ou gerenciador de jogo, se necessário
        GameManager.Instance.SetConstrucaoSelecionada(construcaoSelecionada);// Exemplo:

        // Carrega a cena de seleção da vegetação
        SceneManager.LoadScene(2);
    }
}
