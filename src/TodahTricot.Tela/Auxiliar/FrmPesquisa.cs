using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TodahTricot.Domain.Entities;

namespace TodahTricot.Tela.Auxiliar
{
    public partial class FrmPesquisa : Form
    {
        private IEnumerable<CorModel> corModels;

        public FrmPesquisa()
        {
            InitializeComponent();
        }

        private void bttnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void CarregaLista(IEnumerable<CorModel> corModels)
        {
            this.corModels = corModels;
        }

        private void FrmPesquisa_Load(object sender, EventArgs e)
        {
            foreach (var item in corModels)
                listBox1.Items.Add(string.Concat(item.Codigo, " - ", item.Descricao));
        }
    }
}
