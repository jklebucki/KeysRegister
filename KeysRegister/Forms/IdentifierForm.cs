using KeysRegister.Entities;
using KeysRegister.Services;

namespace KeysRegister.Forms
{
    internal partial class IdentifierForm : Form
    {
        private readonly ObjectType _objectType;
        private readonly IdentifierService _identifierService;
        private IEnumerable<Identifier> source;
        internal IdentifierForm(IdentifierService identifierService, ObjectType type)
        {
            _objectType = type;
            _identifierService = identifierService;
            InitializeComponent();
            SetForm();
            SetDataGridView();
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
            source = _identifierService.GetAllEmployee();
        }

        private void KeyForm()
        {
            Text = "Definicja klucza";
            firstNameLabel.Text = "Nazwa klucza";
            lastNameLabel.Text = "Informacja o kluczu";
            descriptionLabel.Text = "Opis";
            source = _identifierService.GetAllKeys();
        }

        private void SetDataGridView()
        {
            SetForm();
            dataGridView.DataSource = null;
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
            if(e.RowIndex >=0)
            {
                var row = dataGridView.Rows[e.RowIndex];
                rfidTextBox.Text = row.Cells[1].Value.ToString();
                firstNameTextBox.Text = row.Cells[2].Value.ToString();
                lastNameTextBox.Text = row.Cells[3].Value.ToString();
                descriptionTextBox.Text = row.Cells[4].Value.ToString();
            }
        }

        private void rfidCodeLabel_DoubleClick(object sender, EventArgs e)
        {
            rfidTextBox.Text = Guid.NewGuid().ToString();
        }
    }
}
