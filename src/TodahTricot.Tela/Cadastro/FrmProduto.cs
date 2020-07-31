using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TodahTricot.Application.Interfaces.Repositories;
using TodahTricot.Domain.Entities;
using TodahTricot.Tela.Properties;

namespace TodahTricot.Tela.Cadastro
{
    public partial class FrmProduto : Form
    {
        private readonly IProdutoRepository produtoRepository;
        private readonly IServiceProvider serviceProvider;
        private ProdutoModel produtoModel;

        public FrmProduto(IProdutoRepository produtoRepository,
            IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.produtoRepository = produtoRepository;
            this.serviceProvider = serviceProvider;
            ValidaForm();
        }

        private void bttnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnImagem_Click(object sender, EventArgs e)
        {
            if (pnFlDlgFoto.ShowDialog() == DialogResult.OK)
            {
                pctrBxProduto.ImageLocation = pnFlDlgFoto.FileName;
                pctrBxProduto.Load();
            }
        }

        private void bttnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void bttnGravar_Click(object sender, EventArgs e)
        {
            if (txtBxCodigo.Text == "" || txtBxDescricao.Text == "")
                return;

            if (produtoModel == null)
                produtoModel = new ProdutoModel();

            if (pctrBxProduto.Image != null)
                using (var ms = new MemoryStream())
                {
                    if (produtoModel.Imagem == null)
                        produtoModel.Imagem = new ImagemModel();

                    pctrBxProduto.Image.Save(ms, pctrBxProduto.Image.RawFormat);
                    produtoModel.Imagem.Arquivo = ms.ToArray();
                }

            produtoModel.Codigo = txtBxCodigo.Text;
            produtoModel.Descricao = txtBxDescricao.Text;

            if (produtoModel.Novo)
                produtoRepository.Inserir(produtoModel);
            else
                produtoRepository.Alterar(produtoModel);

            bttnLimpar_Click(sender, e);
        }

        private void bttnLimpar_Click(object sender, EventArgs e)
        {
            pctrBxProduto.Image = null;
            pctrBxProduto.Update();
            produtoModel = null;
            txtBxCodigo.Text = "";
            txtBxDescricao.Text = "";
            ValidaForm();
            txtBxCodigo.Focus();
        }

        private void bttnExcluir_Click(object sender, EventArgs e)
        {
            produtoRepository.Excluir(produtoModel.Id);
            bttnLimpar_Click(sender, e);
        }

        private void txtBxCodigo_Validated(object sender, EventArgs e)
        {
            produtoModel = produtoRepository.ObterPorCodigo(txtBxCodigo.Text);
            if (produtoModel != null)
            {
                if (produtoModel.Imagem != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        ms.Write(produtoModel.Imagem.Arquivo, 0, Convert.ToInt32(produtoModel.Imagem.Arquivo.Length));
                        pctrBxProduto.Image = new Bitmap(ms, false);
                    }
                }

                txtBxDescricao.Text = produtoModel.Descricao;
            }

            ValidaForm();
        }

        private void txtBxCodigo_TextChanged(object sender, EventArgs e)
        {
            produtoModel = null;
            ValidaForm();
            txtBxDescricao.Text = "";
        }

        private void txtBxDescricao_Validated(object sender, EventArgs e)
        {
            ValidaForm();
        }

        private void ValidaForm()
        {
            bttnGravar.Enabled = txtBxCodigo.Text != "" && txtBxDescricao.Text != "";

            if (produtoModel == null)
            {
                bttnGravar.Text = Mensagens.Gravar;
                bttnExcluir.Enabled = false;
                return;
            }

            bttnGravar.Text = produtoModel.Novo ? Mensagens.Gravar : Mensagens.Alterar;
            bttnExcluir.Enabled = !produtoModel.Novo;
        }
    }
}
