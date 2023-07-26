using System.Text.Json.Serialization;

namespace FormCadastro.mvc.Dtos
{
    public class EnderecoResponse
    {

        //Aqui, configuramos o retorno que queremos. Util para apis em outras linguagens para que você personalize.
        public string? Cep { get; set; }
        public string? Endereco { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Estado { get; set; }

        //Não retornando os dados abaixo para o usuario, deixando ele apenas "em baixo dos panos"
        [JsonIgnore]
        public string? Uf { get; set; }

        [JsonIgnore]
        public string? Ibge { get; set; }

        [JsonIgnore]
        public string? Gia { get; set; }

        [JsonIgnore]
        public string? Ddd { get; set; }

        [JsonIgnore]
        public string? Siafi { get; set; }
    }
}
