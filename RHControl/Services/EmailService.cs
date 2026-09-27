using System;
using System.Net;
using System.Net.Mail;
using System.Security.Authentication;

namespace RHControl.Services
{
    public static class EmailService
    {
        private const string EmailRemetente =
            "rhcontrol26@gmail.com";

        private const string ServidorSmtp =
            "smtp.gmail.com";

        private const int PortaSmtp = 587;

        // ============================================================
        // SENHA DE APLICATIVO DO GOOGLE
        // ============================================================

        private const string SenhaAplicativo =
            "COLE_AQUI_A_SENHA_DE_APLICATIVO";

        // ============================================================
        // ENVIA O CÓDIGO
        // ============================================================

        public static void EnviarCodigo(
            string emailDestino,
            string codigo)
        {
            if (string.IsNullOrWhiteSpace(emailDestino))
            {
                throw new Exception(
                    "O e-mail do destinatário não foi informado.");
            }

            if (string.IsNullOrWhiteSpace(codigo))
            {
                throw new Exception(
                    "O código de recuperação não foi informado.");
            }

            if (SenhaAplicativo ==
                "COLE_AQUI_A_SENHA_DE_APLICATIVO")
            {
                throw new Exception(
                    "A senha de aplicativo do Gmail não foi configurada.");
            }

            string senha =
                SenhaAplicativo
                    .Replace(" ", "")
                    .Trim();

            try
            {
                // ====================================================
                // FORÇA TLS 1.2
                // ====================================================

                System.Net.ServicePointManager.SecurityProtocol =
                    System.Net.SecurityProtocolType.Tls12;

                using MailMessage mensagem =
                    new MailMessage();

                mensagem.From =
                    new MailAddress(
                        EmailRemetente,
                        "RH Control");

                mensagem.To.Add(
                    emailDestino.Trim());

                mensagem.Subject =
                    "RH Control - Código de recuperação de senha";

                mensagem.Body =
                    "Olá!\r\n\r\n" +

                    "Recebemos uma solicitação para redefinir " +
                    "a senha do seu acesso ao RH Control.\r\n\r\n" +

                    "Seu código de verificação é:\r\n\r\n" +

                    codigo +

                    "\r\n\r\n" +

                    "Este código é válido por 10 minutos.\r\n\r\n" +

                    "Se você não solicitou esta alteração, " +
                    "ignore este e-mail.\r\n\r\n" +

                    "Atenciosamente,\r\n" +
                    "RH Control\r\n" +
                    "Gestão de Pessoas";

                mensagem.IsBodyHtml = false;

                using SmtpClient smtp =
                    new SmtpClient();

                smtp.Host =
                    ServidorSmtp;

                smtp.Port =
                    PortaSmtp;

                smtp.EnableSsl =
                    true;

                smtp.UseDefaultCredentials =
                    false;

                smtp.Credentials =
                    new NetworkCredential(
                        EmailRemetente,
                        senha);

                smtp.DeliveryMethod =
                    SmtpDeliveryMethod.Network;

                smtp.Timeout =
                    60000;

                // ====================================================
                // ENVIO
                // ====================================================

                smtp.Send(mensagem);
            }
            catch (SmtpException ex)
            {
                string mensagemErro =
                    "Falha no envio pelo Gmail.\r\n\r\n" +
                    "Mensagem:\r\n" +
                    ex.Message;

                if (ex.InnerException != null)
                {
                    mensagemErro +=
                        "\r\n\r\nDetalhes:\r\n" +
                        ex.InnerException.Message;
                }

                throw new Exception(
                    mensagemErro,
                    ex);
            }
            catch (Exception ex)
            {
                string mensagemErro =
                    "Não foi possível enviar o código por e-mail.\r\n\r\n" +
                    "Mensagem:\r\n" +
                    ex.Message;

                if (ex.InnerException != null)
                {
                    mensagemErro +=
                        "\r\n\r\nDetalhes:\r\n" +
                        ex.InnerException.Message;
                }

                throw new Exception(
                    mensagemErro,
                    ex);
            }
        }
    }
}