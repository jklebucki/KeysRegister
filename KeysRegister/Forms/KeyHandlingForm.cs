using KeysRegister.Entities;
using KeysRegister.Repository;
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
        private ReleaseKeys _releaseKeys = new();
        public KeyHandlingForm(OperationType operationType, IdentifierService identifierService)
        {
            InitializeComponent();
            _operationType = operationType;
            _identifierService = identifierService;
            SetForm();
        }

        private void SetForm()
        {
            if (_operationType == OperationType.Out)
            {
                Text = "Wydanie klucza";
                employeeLabel.Text = "Pobierający";
            }
            else if (_operationType == OperationType.In)
            {
                Text = "Zwrot klucza";
                employeeLabel.Text = "Zwracający";
            }
            FillKeysDataGridView();
        }

        private void FillKeysDataGridView()
        {
            keysDataGridView.DataSource = null;
            keysDataGridView.DataSource = _releaseKeys.Keys;
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
            employeeFirstNameLabel.Text = _releaseKeys.Employee.FirstName;
            employeeLastNameLabel.Text = _releaseKeys.Employee.LastName;
            employeeDepartmentLabel.Text = _releaseKeys.Employee.Description;
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
                _releaseKeys.SetEmployee(identifier);
            else if (identifier.Type == ObjectType.Key)
                _releaseKeys.AddKey(identifier);
        }

    }
}
