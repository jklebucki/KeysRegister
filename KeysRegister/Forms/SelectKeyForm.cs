using KeysRegister.Entities;
using KeysRegister.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeysRegister.Forms
{
    internal partial class SelectKeyForm : Form
    {
        public Identifier? Identifier { get; protected set; }
        private readonly IdentifierService _identifierService;
        internal SelectKeyForm(IdentifierService identifierService)
        {
            _identifierService = identifierService;
            identifierService.RefreshKeys();
            InitializeComponent();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchPhraseLength = ((TextBox)sender).Text.Length;
            if (searchPhraseLength >= 3)
            {
                var source = _identifierService.FindKey(((TextBox)sender).Text);
                FillKeysDataGridView(source);
            }
            else if (searchPhraseLength == 0)
            {
                ClearKeysDataGridView();
            }
        }
        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var source = _identifierService.FindKey(((TextBox)sender).Text);
                if (source.Count() == 1)
                {
                    Identifier = source.First();
                    Close();
                }
            }
        }

        private void FillKeysDataGridView(IEnumerable<Identifier> source)
        {
            keysDataGridView.DataSource = null;
            keysDataGridView.DataSource = source;
            SetColumnsKeysDataGridView();
        }

        private void ClearKeysDataGridView()
        {
            keysDataGridView.DataSource = null;
            keysDataGridView.Invalidate();
        }

        private void SetColumnsKeysDataGridView()
        {
            keysDataGridView.Columns[0].Visible = false;
            keysDataGridView.Columns[1].Visible = false;
            keysDataGridView.Columns[2].HeaderText = "Nazwa klucza";
            keysDataGridView.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            keysDataGridView.Columns[3].HeaderText = "Informacja o kluczu";
            keysDataGridView.Columns[3].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            keysDataGridView.Columns[4].HeaderText = "Opis";
            keysDataGridView.Columns[4].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            keysDataGridView.Columns[5].Visible = false;
            keysDataGridView.Invalidate();
        }

        private void keysDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (int.TryParse(keysDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), out int keyId))
            {
                Identifier = _identifierService.GetIdentifierById(keyId);
                Close();
            }
        }
    }
}
