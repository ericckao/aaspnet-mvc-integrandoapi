using System.Dynamic; // Importa o namespace System.Dynamic para utilizar ExpandoObject

namespace FormCadastro.mvc.Dtos
{
    // Definição da classe genérica ResponseGenerico<T>
    // Onde T será substituído por um tipo específico quando a classe for usada
    public class ResponseGenerico<T> where T : class
    {
        // Propriedade pública do tipo HttpClient para armazenar o código de status HTTP da resposta
        public HttpClient CodigoHttp { get; set; }

        // Propriedade pública do tipo T (genérico) para armazenar os dados de retorno da resposta
        public T? DadosRetorno { get; set; }

        // Propriedade pública do tipo ExpandoObject para armazenar informações de erro da resposta
        public ExpandoObject? ErroRetorno { get; set; }
    }
}

