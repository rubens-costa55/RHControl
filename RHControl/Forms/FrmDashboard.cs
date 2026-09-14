using RHControl.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RHControl
{
    public partial class FrmDashboard : Form
    {
        private bool encerrandoSessao;
        public FrmDashboard()
        {
            InitializeComponent();

            btnFuncionarios.Click += BtnFuncionarios_Click;
            btnJornada.Click += BtnJornada_Click;
            btnFolha.Click += BtnFolha_Click;
            btnConfiguracoes.Click += BtnConfiguracoes_Click;
            btnSair.Click += BtnSair_Click;

            AplicarPermissoes();
        }

        private void AplicarPermissoes()
        {
            // O Dashboard e as telas de consulta continuam disponíveis.
            btnDashboard.Enabled = true;
            btnFuncionarios.Enabled = true;
            btnJornada.Enabled = true;
            btnFolha.Enabled = true;

            // Configurações é exclusivo do Administrador.
            btnConfiguracoes.Visible = SessaoUsuario.PodeConfigurar;
            btnConfiguracoes.Enabled = SessaoUsuario.PodeConfigurar;

            // Mostra no topo quem está conectado e o nível de acesso.
            if (lblUsuario != null)
            {
                string nome = string.IsNullOrWhiteSpace(SessaoUsuario.Nome)
                    ? SessaoUsuario.Usuario
                    : SessaoUsuario.Nome;

                string tipo = SessaoUsuario.EhAdministrador
                    ? "Administrador"
                    : "Usuário";

                lblUsuario.Text = "●  " + nome + "  •  " + tipo;
            }
        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmFuncionarios());
        }

        private void BtnJornada_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmJornada());
        }

        private void BtnFolha_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmFolhaPagamento());
        }

        private void BtnConfiguracoes_Click(object sender, EventArgs e)
        {
            // Segunda camada de segurança: mesmo que o botão seja acionado
            // por outro caminho, Usuário não pode abrir Configurações.
            if (!SessaoUsuario.PodeConfigurar)
            {
                MessageBox.Show(
                    "Seu perfil permite apenas visualizar informações e exportar relatórios.\n\n" +
                    "O acesso às Configurações é exclusivo do Administrador.",
                    "Acesso restrito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            AbrirForm(new FrmConfiguracoes());
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                "Deseja realmente sair do RH Control?",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes)
                return;

            // Encerra a sessão antes de fechar o Dashboard.
            // O Login reconhece que foi logout e permanece aberto.
            SessaoUsuario.Encerrar();

            FrmLogin login = Application.OpenForms
                .OfType<FrmLogin>()
                .FirstOrDefault();

            if (login == null || login.IsDisposed)
                login = new FrmLogin();

            login.Show();
            login.BringToFront();

            // Fecha as telas principais que possam estar abertas.
            foreach (Form form in Application.OpenForms.Cast<Form>().ToArray())
            {
                if (form == login || form == this)
                    continue;

                if (form is FrmFuncionarios ||
                    form is FrmJornada ||
                    form is FrmFolhaPagamento ||
                    form is FrmConfiguracoes)
                {
                    form.Close();
                }
            }

            encerrandoSessao = true;
            Close();
        }

        public void EncerrarPorLogout()
        {
            encerrandoSessao = true;
            Close();
        }

        private void AbrirForm(Form form)
        {
            form.FormClosed += (s, args) =>
            {
                if (!encerrandoSessao && SessaoUsuario.Id > 0 && !IsDisposed)
                {
                    Show();
                    BringToFront();
                }
            };

            Hide();
            form.Show();
        }
    }
}
