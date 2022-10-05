using ModeloPortalAgoraBlazor.Models;

namespace ModeloPortalAgoraBlazor.State
{
    public class ClienteState
    {
        public ClienteState()
        {
            Cliente = new Cliente
            {
                Administradores = new List<Administrador>(),
                Controladores = new List<Controlador>(),
                ContasBancarias = new List<ContaBancaria>(),
                PessoasProprietarias = new List<PessoaProprietaria>(),
                Procuradores = new List<Procurador>(),
                EmissoresOrdees = new List<EmissorOrdem>()
            };
        }

        public Cliente Cliente { get; set; }
        public bool FormConta { get; set; }
    }
}