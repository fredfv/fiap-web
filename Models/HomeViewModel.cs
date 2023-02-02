namespace fiap_web.Models
{
    public class HomeViewModel
    {
        public HomeViewModel(string nomeAluno, string categoriaProduto)
        {
            NomeAluno = nomeAluno;
            CategoriaProduto = categoriaProduto;
        }

        public string NomeAluno { get; set; }
        public string CategoriaProduto { get; set; }
        
    }
}

