using myfinance_web_dotnet_domain;

namespace myfinance_web_dotnet_service.Interfaces
{
    public interface ITransacaoContaService
    {
        void Cadastrar(Transacao Entidade);
        void Excluir(int Id);
        List<Transacao> ListarRegistros();
        Transacao RetornarRegistro(int Id);
    }
}