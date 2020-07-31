using System;
using System.Windows.Forms;
using TodahTricot.Application.Interfaces.Repositories;
using TodahTricot.Domain.Entities;
using TodahTricot.Tela.Properties;

namespace TodahTricot.Tela.Cadastro
{
    public partial class FrmCliente : Form
    {
        private readonly IEnderecoRepository enderecoRepository;
        private readonly IClienteRepository clienteRepository;
        private readonly IServiceProvider serviceProvider;
        private ClienteModel clienteModel;

        public FrmCliente(IEnderecoRepository enderecoRepository,
            IClienteRepository clienteRepository,
            IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.enderecoRepository = enderecoRepository;
            this.clienteRepository = clienteRepository;
            this.serviceProvider = serviceProvider;
            ValidaForm();
        }

        private void bttnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void bttnGravar_Click(object sender, EventArgs e)
        {
            if (txtBxDocumento.Text == "" || txtBxNome.Text == "")
                return;

            if (clienteModel == null)
                clienteModel = new ClienteModel();

            clienteModel.Documento = txtBxDocumento.Text;
            clienteModel.NomeCompleto = txtBxNome.Text;
            clienteModel.Email = txtBxEmail.Text;

            if (clienteModel.Endereco == null)
                clienteModel.Endereco = new EnderecoModel();

            clienteModel.Endereco.Cep = txtBxDocumento.Text;
            clienteModel.Endereco.Endereco = txtBxNome.Text;
            clienteModel.Endereco.Numero = txtBxNumero.Text;
            clienteModel.Endereco.Complemento = txtBxComplemento.Text;
            clienteModel.Endereco.Municipio = txtBxMunicipio.Text;
            clienteModel.Endereco.Uf = lstBxUF.SelectedItem.ToString();

            if (clienteModel.Novo)
                clienteRepository.Inserir(clienteModel);
            else
                clienteRepository.Alterar(clienteModel);

            bttnLimpar_Click(sender, e);
        }

        private void bttnLimpar_Click(object sender, EventArgs e)
        {
            clienteModel = null;
            txtBxDocumento.Text = "";
            txtBxNome.Text = "";
            ValidaForm();
            txtBxDocumento.Focus();
        }

        private void bttnExcluir_Click(object sender, EventArgs e)
        {
            clienteRepository.Excluir(clienteModel.Id);
            bttnLimpar_Click(sender, e);
        }

        private void txtBxDocumento_Validated(object sender, EventArgs e)
        {
            clienteModel = clienteRepository.ObterPorDocumento(txtBxDocumento.Text);
            if (clienteModel != null)
            {
                txtBxNome.Text = clienteModel.NomeCompleto;
                txtBxEmail.Text = clienteModel.Email;
            }

            ValidaForm();
        }

        private void txtBxDocumento_TextChanged(object sender, EventArgs e)
        {
            clienteModel = null;
            txtBxNome.Text = "";
            txtBxCep.Text = "";
            ValidaForm();
        }

        private void txtBxNome_Validated(object sender, EventArgs e)
        {
            ValidaForm();
        }

        private void ValidaForm()
        {
            bttnGravar.Enabled = txtBxDocumento.Text != "" && txtBxNome.Text != "" && txtBxCep.Text != "" && txtBxEndereco.Text != "" && txtBxMunicipio.Text != "";

            if (clienteModel == null)
            {
                bttnGravar.Text = Mensagens.Gravar;
                bttnExcluir.Enabled = false;
                return;
            }

            bttnGravar.Text = clienteModel.Novo ? Mensagens.Gravar : Mensagens.Alterar;
            bttnExcluir.Enabled = !clienteModel.Novo;
        }

        private void txtBxCep_Validated(object sender, EventArgs e)
        {
            var enderecoModel = enderecoRepository.ObterPorCep(txtBxCep.Text);

            if (enderecoModel != null)
            {
                txtBxNome.Text = clienteModel.NomeCompleto;
                txtBxEmail.Text = clienteModel.Email;
            }

            ValidaForm();
        }

        private void txtBxCep_TextChanged(object sender, EventArgs e)
        {
            txtBxEndereco.Text = "";
            txtBxNumero.Text = "";
            txtBxComplemento.Text = "";
            txtBxMunicipio.Text = "";
            lstBxUF.SelectedIndex = 0;
        }
    }
}
