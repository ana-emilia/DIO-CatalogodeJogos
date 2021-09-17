using CatalogoJogosDio.InputModel;
using CatalogoJogosDio.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoJogosDio.Services
{
    public interface IJogoService : IDisposable
    {
        Task<List<JogosViewModel>> Obter(int pagina, int quantidade);
            Task<JogosViewModel> Obter(Guid id);
        Task<JogosViewModel> Inserir(JogosInputModel jogo);
            Task Atualizar(Guid id, JogosInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}