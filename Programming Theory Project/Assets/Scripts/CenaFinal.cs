using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CenaFinal : MonoBehaviour
{
    public GameObject prefabConstrucao;
    public GameObject[] prefabVegetacao;
    public GameObject[] prefabGrama;
    public TMP_Text nomeAmbienteText;
    public Button voltarMenuButton;

    private void Start()
    {
        // Obtém os dados do ambiente e seleções anteriores, se necessário
        string nomeAmbiente = GameManager.Instance.GetNomeAmbiente();// Exemplo: 
        int construcaoSelecionada = GameManager.Instance.GetConstrucaoSelecionada();
        int vegetacaoSelecionada = GameManager.Instance.GetVegetacaoSelecionada();

        // Define o nome do ambiente no texto
        nomeAmbienteText.text = nomeAmbiente;



        // Instancia o prefab da construção selecionada   Vector3(-7.95,0.05,5.7)
        GameObject construcao = Instantiate(prefabConstrucao, transform.position + new Vector3(-7.95f, 0.05f, 5.7f), Quaternion.identity);



        // Seleciona aleatoriamente entre 1 e 5 prefabs de vegetação
        int quantidadeVegetacao = Random.Range(1, 6); // Gera um número aleatório entre e 5

        for (int i = 0; i < quantidadeVegetacao; i++)
        {
            int randomIndex = Random.Range(0, prefabVegetacao.Length); // Gera um índice aleatório dentro do tamanho da lista

            Vector3 randomPosition = transform.position + new Vector3(Random.Range(-4.5f, 0f), 0f, Random.Range(8.5f, 0f));
            Vector3 randomPositionL = transform.position + new Vector3(Random.Range(-11f, -15f), 0f, Random.Range(8.5f, 0f));
            Quaternion randomRotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);

            Instantiate(prefabVegetacao[randomIndex], randomPosition, randomRotation);
            Instantiate(prefabVegetacao[randomIndex], randomPositionL, randomRotation);

        }


        int quantidadeGrama = Random.Range(5, 20);

        for (int i = 0; i < quantidadeGrama; i++)
        {
            int randomIndexPrefabGrama = Random.Range(0, prefabGrama.Length);

            Vector3 randomPosition = transform.position + new Vector3(Random.Range(-1.5f, -10f), 0f, Random.Range(-8f, 1f));
            Quaternion randomRotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);

            Instantiate(prefabGrama[randomIndexPrefabGrama], randomPosition, randomRotation);
        }





        voltarMenuButton.onClick.AddListener(VoltarAoMenu);
    }



    private void VoltarAoMenu()
    {
        // Carrega a cena do menu inicial
        SceneManager.LoadScene("TitleScreen");
    }
}
