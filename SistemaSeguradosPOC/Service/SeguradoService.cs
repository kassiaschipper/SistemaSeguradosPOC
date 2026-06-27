using System;
using System.Collections.Generic;
using SistemaSeguradosPOC.Models;
using SistemaSeguradosPOC.Repository;

namespace SistemaSeguradosPOC.Service
{
    public class SeguradoService
    {
        private readonly SeguradoRepository _seguradoRepository;
        
        public SeguradoService()
        {
            _seguradoRepository = new SeguradoRepository();
        }
        
        public void CadastrarSegurado(Segurado segurado)
        {
           if(string.IsNullOrWhiteSpace(segurado.Nome))
                throw new Exception("Nome obrigatório.");
            if (string.IsNullOrWhiteSpace(segurado.Cpf))
                throw new Exception("CPF obrigatório");
            if (segurado.ValorContribuicao <= 0)
                throw new Exception("Valor de contribuição deve ser maior que zero.");
            
            _seguradoRepository.InserirSegurado(segurado);
        }

        public List<Segurado> BuscarTodosSegurados()
        {
            return _seguradoRepository.BuscarTodosSegurados();
        }
    }
}

