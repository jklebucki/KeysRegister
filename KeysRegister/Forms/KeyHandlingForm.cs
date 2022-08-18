using KeysRegister.Entities;
using KeysRegister.Services;
using System.Text;

namespace KeysRegister.Forms
{
    public enum OperationType
    {
        In, Out
    }
    public partial class KeyHandlingForm : Form
    {
        private readonly OperationType _operationType;
        private readonly IdentifierService _identifierService;
        private readonly StringBuilder _code = new StringBuilder();
        public ReleaseKeys ReleaseKeys { get; protected set; }
        public KeyHandlingForm(OperationType operationType, IdentifierService identifierService)
        {
            InitializeComponent();
            ReleaseKeys = new ReleaseKeys();
            _operationType = operationType;
            _identifierService = identifierService;
            SetForm();
        }

        private void SetForm()
        {
            if (_operationType == OperationType.Out)
            {
                Text = "Wydanie klucza";
                employeeLabel.Text = "Pobierający [szukaj]";
            }
            else if (_operationType == OperationType.In)
            {
                Text = "Zwrot klucza";
                employeeLabel.Text = "Zwracający [szukaj]";
            }
            FillKeysDataGridView();
        }

        private void FillKeysDataGridView()
        {
            keysDataGridView.DataSource = null;
            keysDataGridView.DataSource = ReleaseKeys.Keys;
            keysDataGridView.Columns[0].Visible = false;
            keysDataGridView.Columns[1].Visible = false;
            keysDataGridView.Columns[2].HeaderText = "Identyfikator";
            keysDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            keysDataGridView.Columns[3].HeaderText = "Informacja";
            keysDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            keysDataGridView.Columns[4].HeaderText = "Opis";
            keysDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            keysDataGridView.Columns[5].Visible = false;
            keysDataGridView.Invalidate();
        }

        private void FillEmployeeData()
        {
            if (ReleaseKeys.Employee != null)
            {
                employeeFirstNameLabel.Text = ReleaseKeys.Employee.FirstName;
                employeeLastNameLabel.Text = ReleaseKeys.Employee.LastName;
                employeeDepartmentLabel.Text = ReleaseKeys.Employee.Description;
            }
        }

        private void KeyHandlingForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                _code.Append(e.KeyChar);
            else
            {
                var str = _code.ToString();
                var ident = _identifierService.GetIdentifierByRfidCode(str);
                if (ident != null)
                {
                    SetReleaseKeys(ident);
                    FillKeysDataGridView();
                    FillEmployeeData();
                    infoLabel.Text = string.Empty;
                }
                else
                    infoLabel.Text = "Nie znaleziono";
                _code.Clear();
            }
        }

        private void SetReleaseKeys(Identifier identifier)
        {
            if (identifier.Type == ObjectType.Person)
                ReleaseKeys.SetEmployee(identifier);
            else if (identifier.Type == ObjectType.Key)
                ReleaseKeys.AddKey(identifier);
        }

        private void employeeLabel_Click(object sender, EventArgs e)
        {
            SelectEmployeeForm selectEmployeeForm = new SelectEmployeeForm(_identifierService);
            selectEmployeeForm.FormClosing += SetEmployee;
            selectEmployeeForm.ShowDialog();
        }

        private void SetEmployee(object sender, FormClosingEventArgs e)
        {
            var searchEmployeeForm = (SelectEmployeeForm)sender;
            if (searchEmployeeForm.Identifier != null)
            {
                ReleaseKeys.SetEmployee(searchEmployeeForm.Identifier);
                FillEmployeeData();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
