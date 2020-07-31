using System;
using System.Windows.Forms;
using TodahTricot.Application.Interfaces.Repositories;
using TodahTricot.Domain.Entities;

namespace TodahTricot.Tela.Cadastro
{
    public partial class FrmDespesa : Form
    {
        private readonly IDespesaRepository despesaRepository;
        private readonly IServiceProvider serviceProvider;
        private DespesaModel despesaModel;

        public FrmDespesa(IDespesaRepository despesaRepository,
            IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.despesaRepository = despesaRepository;
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

            if (despesaModel == null)
                despesaModel = new DespesaModel();

            despesaModel.Codigo = txtBxCodigo.Text;
            despesaModel.Descricao = txtBxDescricao.Text;

            if (despesaModel.Novo)
                despesaRepository.Inserir(despesaModel);
            else
                despesaRepository.Alterar(despesaModel);

            bttnLimpar_Click(sender, e);
        }

        private void bttnLimpar_Click(object sender, EventArgs e)
        {
            despesaModel = null;
            txtBxCodigo.Text = "";
            txtBxDescricao.Text = "";
            ValidaForm();
            txtBxCodigo.Focus();
        }

        private void bttnExcluir_Click(object sender, EventArgs e)
        {
            despesaRepository.Excluir(despesaModel.Id);
            bttnLimpar_Click(sender, e);
        }

        private void txtBxCodigo_Validated(object sender, EventArgs e)
        {
            despesaModel = despesaRepository.ObterPorCodigo(txtBxCodigo.Text);
            if (despesaModel != null)
                txtBxDescricao.Text = despesaModel.Descricao;

            ValidaForm();
        }

        private void txtBxDescricao_Validated(object sender, EventArgs e)
        {
            ValidaForm();
        }

        private void txtBxCodigo_TextChanged(object sender, EventArgs e)
        {
            despesaModel = null;
            ValidaForm();
            txtBxDescricao.Text = "";
        }

        private void ValidaForm()
        {
            bttnGravar.Enabled = txtBxCodigo.Text != "" && txtBxDescricao.Text != "";

            if (despesaModel == null)
            {
                bttnGravar.Text = "Gravar";
                bttnExcluir.Enabled = false;
                return;
            }

            bttnGravar.Text = despesaModel.Novo ? "Gravar" : "Alterar";
            bttnExcluir.Enabled = !despesaModel.Novo;
        }
    }
}
