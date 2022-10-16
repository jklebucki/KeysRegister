using KeysRegister.Entities;
using KeysRegister.Services;

namespace KeysRegister.Forms
{

    internal partial class IdentifierForm : Form
    {
        private enum FormState
        {
            Add,
            Edit,
            Cancel,
        }

        private readonly ObjectType _objectType;
        private readonly IdentifierService _identifierService;
        private IEnumerable<Identifier> source;
        private FormState _state;
        private DataGridViewRow? _selectedRow;

        internal IdentifierForm(IdentifierService identifierService, ObjectType type)
        {
            _objectType = type;
            _identifierService = identifierService;
            InitializeComponent();
            FormControlsState(FormState.Cancel);
            SetForm();
            SetDataGridView();
        }

        private void FormControlsState(FormState formState)
        {
            _state = formState;
            switch (_state)
            {
                case FormState.Add:
                    rfidTextBox.Enabled = true;
                    firstNameTextBox.Enabled = true;
                    lastNameTextBox.Enabled = true;
                    descriptionTextBox.Enabled = true;
                    btnSave.Enabled = true;
                    btnAdd.Enabled = false;
                    btnRemove.Enabled = false;
                    break;
                case FormState.Edit:
                    rfidTextBox.Enabled = true;
                    firstNameTextBox.Enabled = true;
                    lastNameTextBox.Enabled = true;
                    descriptionTextBox.Enabled = true;
                    btnSave.Enabled = true;
                    btnRemove.Enabled = _selectedRow != null ? true : false;
                    btnAdd.Enabled = true;
                    break;
                case FormState.Cancel:
                    rfidTextBox.Enabled = false;
                    rfidTextBox.Text = string.Empty;
                    firstNameTextBox.Enabled = false;
                    firstNameTextBox.Text = string.Empty;
                    lastNameTextBox.Enabled = false;
                    lastNameTextBox.Text = string.Empty;
                    descriptionTextBox.Enabled = false;
                    descriptionTextBox.Text = string.Empty;
                    btnSave.Enabled = false;
                    btnAdd.Enabled = true;
                    btnRemove.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void SetForm()
        {
            switch (_objectType)
            {
                case ObjectType.Key:
                    KeyForm();
                    break;
                case ObjectType.Person:
                    PersonForm();
                    break;
                default:
                    break;
            }
        }

        private void PersonForm()
        {
            Text = "Definicja pobierającego";

        }

        private void KeyForm()
        {
            Text = "Definicja klucza";
            firstNameLabel.Text = "Nazwa klucza";
            lastNameLabel.Text = "Informacja o kluczu";
            descriptionLabel.Text = "Opis";
        }

        private void GetSource()
        {
            switch (_objectType)
            {
                case ObjectType.Key:
                    source = _identifierService.GetAllKeys();
                    break;
                case ObjectType.Person:
                    source = _identifierService.GetAllEmployee();
                    break;
                default:
                    break;
            }
        }

        private void SetDataGridView()
        {
            SetForm();
            dataGridView.DataSource = null;
            GetSource();
            dataGridView.DataSource = source;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[5].Visible = false;
            switch (_objectType)
            {
                case ObjectType.Key:
                    SetKeyColumns();
                    break;
                case ObjectType.Person:
                    SetPersonColumns();
                    break;
                default:
                    break;
            }
            dataGridView.Invalidate();
        }

        private void SetKeyColumns()
        {
            dataGridView.Columns[1].HeaderText = "Kod RFID";
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[2].HeaderText = "Imię";
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[3].HeaderText = "Nazwisko";
            dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[4].HeaderText = "Opis";
            dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void SetPersonColumns()
        {
            dataGridView.Columns[1].HeaderText = "Kod RFID";
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[2].HeaderText = "Nazwa klucza";
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[3].HeaderText = "Informacja o kluczu";
            dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[4].HeaderText = "Opis";
            dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedRow = dataGridView.Rows[e.RowIndex];
                rfidTextBox.Text = _selectedRow.Cells[1].Value.ToString();
                firstNameTextBox.Text = _selectedRow.Cells[2].Value.ToString();
                lastNameTextBox.Text = _selectedRow.Cells[3].Value.ToString();
                descriptionTextBox.Text = _selectedRow.Cells[4].Value.ToString();
                FormControlsState(FormState.Edit);
            }
        }

        private void rfidCodeLabel_DoubleClick(object sender, EventArgs e)
        {
            rfidTextBox.Text = Guid.NewGuid().ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormControlsState(FormState.Add);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var row = _selectedRow?.DataBoundItem as Identifier;
            _identifierService.RemoveIdentifier(row);
            SetDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_state)
                {
                    case FormState.Add:
                        _identifierService.AddIdentifier(
                            new Identifier(0, rfidTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text, descriptionTextBox.Text, _objectType));
                        break;
                    case FormState.Edit:
                        _identifierService.UpdateIdentifier(
                            new Identifier(int.Parse(_selectedRow.Cells[0].Value.ToString()), rfidTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text, descriptionTextBox.Text, _objectType));
                        break;
                    case FormState.Cancel:
                        break;
                    default:
                        break;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException == null ? ex.Message : ex.InnerException.Message);
            }

            SetDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormControlsState(FormState.Cancel);
        }
    }
}
