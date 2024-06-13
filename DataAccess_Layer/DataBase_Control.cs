using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataAccess_Layer
{
    public class DataBase_Control
    {
        #region Variaveis

        private MySqlParameterCollection parameters;

        #endregion

        public DataBase_Control()
        {
            try
            {
                this.parameters = new MySqlCommand().Parameters;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region Connexão e Interação BD

        private MySqlConnection CreateConnection()
        {
            try
            {
                return new MySqlConnection($"server=127.0.0.1" + "; database=todoList" + "; Uid=root" + "; pwd=todoList" + ";");
            }
            catch (Exception exception)
            {
                throw new Exception("Falha ao criar conexão com o banco de dados.", exception);
            }
        }

        public bool TestConnection()
        {
            try
            {
                using (MySqlConnection connection = CreateConnection())
                    connection.Open();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void AddParameter(string parameterName, object value)
        {
            try
            {
                this.parameters.Add(new MySqlParameter(parameterName, value));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CleanParameter()
        {
            try
            {
                this.parameters.Clear();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void AddCommandParameter(MySqlCommand command)
        {
            try
            {
                command.Parameters.Clear();

                foreach (MySqlParameter parameter in this.parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.ParameterName, parameter.Value));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public object RunScalar(string textCommand, CommandType commandType)
        {
            try
            {
                using (MySqlConnection connection = CreateConnection())
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandTimeout = 7200;
                    command.CommandText = textCommand;
                    command.CommandType = commandType;
                    AddCommandParameter(command);

                    return command.ExecuteScalar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetDataTable(string textCommand, CommandType commandType)
        {
            try
            {
                using (MySqlConnection connection = CreateConnection())
                {
                    connection.Open();

                    MySqlCommand command = connection.CreateCommand();
                    command.CommandTimeout = 7200;
                    command.CommandText = textCommand;
                    command.CommandType = commandType;
                    AddCommandParameter(command);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    return dataSet.Tables[0];
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

    }
}
