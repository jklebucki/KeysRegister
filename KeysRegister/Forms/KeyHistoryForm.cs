using KeysRegister.Entities;
using KeysRegister.Services;
using System.Data;

namespace KeysRegister.Forms
{
    internal partial class KeyHistoryForm : Form
    {
        private readonly IdentifierService _identifierService;
        public Identifier Identifier { get; protected set; }
        internal KeyHistoryForm(IdentifierService identifierService)
        {
            _identifierService = identifierService;
            InitializeComponent();
        }

        private void selectKeyButton_Click(object sender, EventArgs e)
        {
            SelectKeyForm selectKeyForm = new SelectKeyForm(_identifierService);
            selectKeyForm.FormClosing += SelectKeyForm_FormClosing;
            selectKeyForm.ShowDialog();
        }

        private void SelectKeyForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (sender != null)
            {
                var searchForm = (SelectKeyForm)sender;
                if (searchForm.Identifier != null)
                {
                    Identifier = searchForm.Identifier;
                    FillHistory();
                }
            }
        }

        private void FillHistory()
        {
            keyHistoryDataGridView.DataSource = null;
            keyHistoryDataGridView.DataSource = _identifierService.KeyHistory(Identifier.Id).OrderByDescending(d => d.OperationDate).ToList();
            keyHistoryDataGridView.Columns[0].Visible = false;
            keyHistoryDataGridView.Columns[1].Visible = false;
            keyHistoryDataGridView.Columns[5].Visible = false;
            keyHistoryDataGridView.Invalidate();
        }
    }
}
