using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using SistemaSeguradosPOC.Models;

namespace SistemaSeguradosPOC.Repository
{
	public class SeguradoRepository
	{
		private readonly string _connectionString;

		public SeguradoRepository()
		{
			_connectionString = ConfigurationManager.ConnectionStrings["DBSistemasSegurados"].ConnectionString;
		}

        //public bool TestarConexao()
        //{
        //	using (var connection = new SqlConnection(_connectionString))
        //	{
        //		connection.Open();
        //		return connection.State == ConnectionState.Open;
        //	}
        //}
        public bool TestarConexao()
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    return connection.State == ConnectionState.Open;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void InserirSegurado(Segurado segurado)
		{
			using (SqlConnection connection = new SqlConnection(_connectionString))
			{
				string query = @"INSERT INTO Segurados (Nome, Cpf, Email, DataNascimento, ValorContribuicao) VALUES (@Nome, @Cpf,@Email ,@DataNascimento, @ValorContribuicao)";

				using (var command = new SqlCommand(query, connection))
				{
					command.Parameters.Add("@Nome", SqlDbType.VarChar, 100).Value = segurado.Nome;
					command.Parameters.Add("@Cpf", SqlDbType.VarChar, 11).Value = segurado.CPF;
					command.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = segurado.Email;
                    command.Parameters.Add("@DataNascimento", SqlDbType.Date).Value = segurado.DataNascimento;
					command.Parameters.Add("@ValorContribuicao", SqlDbType.Decimal).Value = segurado.ValorContribuicao;

                    connection.Open();
					command.ExecuteNonQuery();
				}
				
			}
		}

		public List<Segurado> BuscarTodosSegurados()
		{
			var segurados = new List<Segurado>();

			using (SqlConnection connection = new SqlConnection(_connectionString))
			{
				string query = "SELECT Id, Nome, CPF, DataNascimento FROM Segurados";
			
				using (var command = new SqlCommand(query, connection))
				{
					connection.Open();
					
					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							var segurado = new Segurado
							{
								Id = Convert.ToInt32(reader["Id"]),
								Nome = reader["Nome"].ToString(),
								CPF = reader["Cpf"].ToString(),
								DataNascimento = Convert.ToDateTime(reader["DataNascimento"])
							};

							segurados.Add(segurado);
						}
					}
				}
			}
			return segurados;
		}
	}
}
