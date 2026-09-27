using System;

namespace RHControl
{
    public static class SessaoUsuario
    {
        public static int Id { get; private set; }
        public static string Nome { get; private set; } = string.Empty;
        public static string Usuario { get; private set; } = string.Empty;
        public static string Email { get; private set; } = string.Empty;
        public static string TipoUsuario { get; private set; } = string.Empty;
        public static string UltimoAcesso { get; private set; } = string.Empty;

        public static bool EhAdministrador =>
            string.Equals(TipoUsuario, "Administrador", StringComparison.OrdinalIgnoreCase);

        // O usuário "admin" é a conta administradora principal do sistema.
        // Ela possui proteção adicional contra exclusão/inativação e é a única
        // conta que pode criar novos administradores.
        public static bool EhAdministradorPrincipal =>
            EhAdministrador &&
            string.Equals(Usuario, "admin", StringComparison.OrdinalIgnoreCase);

        public static bool EhUsuario =>
            string.Equals(TipoUsuario, "Usuario", StringComparison.OrdinalIgnoreCase);

        public static bool PodeVisualizar => true;
        public static bool PodeExportar => true;
        public static bool PodeEditar => EhAdministrador;
        public static bool PodeExcluir => EhAdministrador;
        public static bool PodeConfigurar => EhAdministrador;
        public static bool PodeGerenciarUsuarios => EhAdministrador;

        public static void Iniciar(
            int id,
            string nome,
            string usuario,
            string email,
            string tipoUsuario,
            string ultimoAcesso)
        {
            Id = id;
            Nome = nome ?? string.Empty;
            Usuario = usuario ?? string.Empty;
            Email = email ?? string.Empty;
            TipoUsuario = tipoUsuario ?? "Usuario";
            UltimoAcesso = ultimoAcesso ?? string.Empty;
        }

        public static void AtualizarEmail(string email)
        {
            Email = email ?? string.Empty;
        }

        public static void Encerrar()
        {
            Id = 0;
            Nome = string.Empty;
            Usuario = string.Empty;
            Email = string.Empty;
            TipoUsuario = string.Empty;
            UltimoAcesso = string.Empty;
        }
    }
}
