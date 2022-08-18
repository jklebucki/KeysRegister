using KeysRegister.Entities;
using KeysRegister.Services;

namespace KeysRegister.Forms
{
    public partial class SelectEmployeeForm : Form
    {
        public Identifier? Identifier { get; protected set; }
        private readonly IdentifierService _identifierService;
        public SelectEmployeeForm(IdentifierService identifierService)
        {
            _identifierService = identifierService;
            identifierService.RefreshEmployee();
            InitializeComponent();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchPhraseLength = ((TextBox)sender).Text.Length;
            if (searchPhraseLength >= 3)
            {
                var source = _identifierService.FindEmploee(((TextBox)sender).Text);
                FillEmployeeDataGridView(source);
            }
            else if (searchPhraseLength == 0)
            {
                ClearEmployeeDataGridView();
            }
        }

        private void FillEmployeeDataGridView(IEnumerable<Identifier> source)
        {
            employeeDataGridView.DataSource = null;
            employeeDataGridView.DataSource = source;
            SetColumnsEmployeeDataGridView();
        }

        private void ClearEmployeeDataGridView()
        {
            employeeDataGridView.DataSource = null;
            employeeDataGridView.Invalidate();
        }

        private void SetColumnsEmployeeDataGridView()
        {
            employeeDataGridView.Columns[0].Visible = false;
            employeeDataGridView.Columns[1].Visible = false;
            employeeDataGridView.Columns[2].HeaderText = "Imię";
            employeeDataGridView.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            employeeDataGridView.Columns[3].HeaderText = "Nazwisko";
            employeeDataGridView.Columns[3].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            employeeDataGridView.Columns[4].HeaderText = "Dział";
            employeeDataGridView.Columns[4].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            employeeDataGridView.Columns[5].Visible = false;
            employeeDataGridView.Invalidate();
        }

        private void employeeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int employeeId = 0;
            if (int.TryParse(employeeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), out employeeId))
            {
                Identifier = _identifierService.GetIdentifierById(employeeId);
                Close();
            }
        }
    }
}
