using System;
using System.Windows.Forms;
using TodahTricot.Application.Interfaces.Repositories;
using TodahTricot.Domain.Entities;
using TodahTricot.Tela.Properties;

namespace TodahTricot.Tela.Cadastro
{
    public partial class FrmCor : Form
    {
        private readonly ICorRepository corRepository;
        private readonly IServiceProvider serviceProvider;
        private CorModel corModel;

        public FrmCor(ICorRepository corRepository,
            IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.corRepository = corRepository;
            this.serviceProvider = serviceProvider;
            ValidaForm();
        }

        private void bttnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void bttnGravar_Click(object sender, EventArgs e)
        {
            if (txtBxCodigo.Text == "" || txtBxDescricao.Text == "")
                return;

            if (corModel == null)
                corModel = new CorModel();

            corModel.Codigo = txtBxCodigo.Text;
            corModel.Descricao = txtBxDescricao.Text;

            if (corModel.Novo)
                corRepository.Inserir(corModel);
            else
                corRepository.Alterar(corModel);

            bttnLimpar_Click(sender, e);
        }

        private void bttnLimpar_Click(object sender, EventArgs e)
        {
            corModel = null;
            txtBxCodigo.Text = "";
            txtBxDescricao.Text = "";
            ValidaForm();
            txtBxCodigo.Focus();
        }

        private void bttnExcluir_Click(object sender, EventArgs e)
        {
            corRepository.Excluir(corModel.Id);
            bttnLimpar_Click(sender, e);
        }

        private void txtBxCodigo_Validated(object sender, EventArgs e)
        {
            corModel = corRepository.ObterPorCodigo(txtBxCodigo.Text);
            if (corModel != null)
                txtBxDescricao.Text = corModel.Descricao;

            ValidaForm();
        }

        private void txtBxDescricao_Validated(object sender, EventArgs e)
        {
            ValidaForm();
        }

        private void txtBxCodigo_TextChanged(object sender, EventArgs e)
        {
            corModel = null;
            ValidaForm();
            txtBxDescricao.Text = "";
        }

        private void ValidaForm()
        {
            bttnGravar.Enabled = txtBxCodigo.Text != "" && txtBxDescricao.Text != "";

            if (corModel == null)
            {
                bttnGravar.Text = Mensagens.Gravar;
                bttnExcluir.Enabled = false;
                return;
            }

            bttnGravar.Text = corModel.Novo ? Mensagens.Gravar : Mensagens.Alterar;
            bttnExcluir.Enabled = !corModel.Novo;
        }
    }
}
