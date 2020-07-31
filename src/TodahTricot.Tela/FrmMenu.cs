using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TodahTricot.Tela.Cadastro;

namespace TodahTricot.Tela
{
    public partial class FrmMenu : Form
    {
        private readonly IServiceProvider serviceProvider;
        public FrmMenu(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.serviceProvider = serviceProvider;
        }

        private void bttnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnProduto_Click(object sender, EventArgs e)
        {
            PosicionaPanel(bttnProduto.Top, bttnProduto.Left, bttnProduto.Width);
            var form = serviceProvider.GetRequiredService<FrmProduto>();
            form.ShowDialog(this);
        }

        private void bttnCor_Click(object sender, EventArgs e)
        {
            PosicionaPanel(bttnCor.Top, bttnCor.Left, bttnCor.Width);
            var form = serviceProvider.GetRequiredService<FrmCor>();
            form.ShowDialog(this);
        }

        private void bttnCliente_Click(object sender, EventArgs e)
        {
            PosicionaPanel(bttnCliente.Top, bttnCliente.Left, bttnCliente.Width);
            var form = serviceProvider.GetRequiredService<FrmCliente>();
            form.ShowDialog(this);
        }

        private void bttnFornecedor_Click(object sender, EventArgs e)
        {
            PosicionaPanel(bttnFornecedor.Top, bttnFornecedor.Left, bttnFornecedor.Width);
            //var form = serviceProvider.GetRequiredService<FrmFornecedor>();
            //form.ShowDialog(this);
        }

        private void bttnDespesa_Click(object sender, EventArgs e)
        {
            PosicionaPanel(bttnDespesa.Top, bttnDespesa.Left, bttnDespesa.Width);
            var form = serviceProvider.GetRequiredService<FrmDespesa>();
            form.ShowDialog(this);
        }

        private void bttnEntrada_Click(object sender, EventArgs e)
        {
            PosicionaPanel(bttnEntrada.Top, bttnEntrada.Left, bttnEntrada.Width);
        }

        private void bttnVenda_Click(object sender, EventArgs e)
        {
            PosicionaPanel(bttnVenda.Top, bttnVenda.Left, bttnVenda.Width);
        }

        private void bttnLancamentoDespesas_Click(object sender, EventArgs e)
        {
            PosicionaPanel(bttnLancamentoDespesas.Top, bttnLancamentoDespesas.Left, bttnLancamentoDespesas.Width);
        }

        private void PosicionaPanel(int top, int left, int width)
        {
            pnlMarcacao.Top = top;
            pnlMarcacao.Left = left + width;
        }
    }
}
