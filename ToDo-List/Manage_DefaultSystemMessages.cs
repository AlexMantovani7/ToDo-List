using System;
using System.Windows.Forms;

namespace ToDo_List
{
    public class Manage_DefaultSystemMessages
    {

        #region Confirmation Messages

        public DialogResult Confirmation_Message(string currentOperation)
        {
            try
            {
                return MessageBox.Show("Deseja prosseguir com ( " + currentOperation + " ) desse(s) registro(s) ?", "CONFIRMAR " + currentOperation, MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DialogResult Cancellation_Message()
        {
            try
            {
                return MessageBox.Show("CANCELAR MODIFICAÇÕES REALIZADAS ?", "CANCELANDO MODIFICAÇÕES ", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand,
                    MessageBoxDefaultButton.Button2);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DialogResult WindowClosing_Message(string extraCondition)
        {
            try
            {
                return MessageBox.Show("Deseja fechar essa janela " + extraCondition + "?", "CONFIRMAR ENCERRAMENTO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button2);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Messages About Fields

        public DialogResult NullOrBlank_Field(string field)
        {
            try
            {
                return MessageBox.Show("O campo: ( " + field + " ) não contem INFORMAÇÕES VÁLIDAS ! \n \n Verifique se o campo não está vazio, se contem algum caractere incorreto ou se os dados estão ativos !",
                    "INFORMAÇÕES INVÁLIDAS", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DialogResult CurrencyField_ZeroOrInvalid(string field)
        {
            try
            {
                return MessageBox.Show("O campo: ( " + field + " ) não permite um VALOR ZERADO, NEGATIVO ou EM BRANCO ! \n \n Verifique se o campo não está vazio ou se contem um valor valido acima de ZERO !",
                    "INFORMAÇÕES INVÁLIDAS", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public DialogResult DoubleDateField_NullBlankDated(string field)
        {
            try
            {
                return MessageBox.Show("O campo: ( " + field + " ) não pode conter um VALOR EM BRANCO, DATA informada ultrapassa a DATA DO DIA ATUAL ou DATA INICIAL ultrapassa a DATA FINAL !",
                    "INFORMAÇÕES INVÁLIDAS", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Exception/Errors Messages

        public DialogResult ExceptionMessage(Exception exception)
        {
            try
            {
                string errorMessage = "Ops !!! Ocorrou alguma falha no sistema !\n(RECOMENDADO ENTRAR EM CONTATO COM A EMPRESA CONTRATANTE DO SISTEMA).\n\nMENSAGEM EXCEPTION: '" + exception.Message + "'\n\nSTACK TRACE: (" + exception.StackTrace + ")";
                return MessageBox.Show(errorMessage, "FALHA NO SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DialogResult DataBaseException(string exception)
        {
            try
            {
                return MessageBox.Show("A seguinte EXCEPTION ocorreu ao contactar as informações no Banco de Dados: \n \n" + exception, "EXCEPTION BANCO DE DADOS", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public DialogResult SearchedInformationNotFound_Message()
        {
            try
            {
                return MessageBox.Show("Não foi encontrado registros validos baseado na pesquisa informada !",
                    "INFORMAÇÕES NÃO ENCONTRADAS", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        #endregion

    }
}