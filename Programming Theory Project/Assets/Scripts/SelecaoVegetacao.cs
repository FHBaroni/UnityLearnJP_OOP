using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelecaoVegetacao : MonoBehaviour
{
    public Button vegetacao1Button;
    public Button vegetacao2Button;
    public Button vegetacao3Button;

    private int vegetacaoSelecionada;

    private void Start()
    {
        vegetacao1Button.onClick.AddListener(() => SelecionarVegetacao(1));
        vegetacao2Button.onClick.AddListener(() => SelecionarVegetacao(2));
        vegetacao3Button.onClick.AddListener(() => SelecionarVegetacao(3));
    }

    private void SelecionarVegetacao(int vegetacao)
    {
        vegetacaoSelecionada = vegetacao;

        // Armazena a vegetação selecionada em um objeto de dados ou gerenciador de jogo, se necessário
         GameManager.Instance.SetVegetacaoSelecionada(vegetacaoSelecionada);// Exemplo:

        // Carrega a cena de seleção do terreno
        SceneManager.LoadScene("Ambients");
    }
}
