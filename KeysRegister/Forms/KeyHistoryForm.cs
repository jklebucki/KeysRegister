using KeysRegister.Entities;
using KeysRegister.Services;
using System.Data;

namespace KeysRegister.Forms
{
    internal partial class KeyHistoryForm : Form
    {
        private readonly IdentifierService _identifierService;
        public Identifier? Identifier { get; protected set; }
        internal KeyHistoryForm(IdentifierService identifierService)
        {
            _identifierService = identifierService;
            InitializeComponent();
            keyHistoryDataGridView.CellFormatting += KeyHistoryDataGridView_CellFormatting;
            dateFromDateTimePicker.Value = DateTime.UtcNow.AddDays(-30);
        }

        private void KeyHistoryDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9 && e.Value != null)
                e.Value = e.Value.ToString() == "Return" ? "Zwrot" : "Wydanie";
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
            var dateFrom = dateFromDateTimePicker.Value.ToUniversalTime().Date;
            if (Identifier != null)
            {
                var source = _identifierService.KeyHistory(Identifier.Id, dateFrom).OrderByDescending(d => d.OperationDate).ToList();
                keyHistoryDataGridView.DataSource = source;
            }

            keyHistoryDataGridView.Columns[0].Visible = false;
            keyHistoryDataGridView.Columns[1].Visible = false;
            keyHistoryDataGridView.Columns[2].HeaderText = "Nazwa klucza";
            keyHistoryDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            keyHistoryDataGridView.Columns[3].HeaderText = "Informacja o kluczu";
            keyHistoryDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            keyHistoryDataGridView.Columns[4].HeaderText = "Opis klucza";
            keyHistoryDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            keyHistoryDataGridView.Columns[5].Visible = false;
            keyHistoryDataGridView.Columns[6].HeaderText = "Imię";
            keyHistoryDataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            keyHistoryDataGridView.Columns[7].HeaderText = "Nazwisko";
            keyHistoryDataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            keyHistoryDataGridView.Columns[8].HeaderText = "Opis";
            keyHistoryDataGridView.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            keyHistoryDataGridView.Columns[9].HeaderText = "Rodzaj operacji";
            keyHistoryDataGridView.Columns[9].ValueType = typeof(string);
            keyHistoryDataGridView.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            keyHistoryDataGridView.Columns[10].HeaderText = "Data operacji";
            keyHistoryDataGridView.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            keyHistoryDataGridView.Invalidate();
        }
    }
}
