using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace lab02
{
    public partial class Bank : Form
    {
        private Owner Instance;
        private byte State = 1;
        private readonly string[] COMBOBOX_VALUES_CITY = {
            "Минск",
            "Гродно",
            "Витебск",
            "Гомель",
            "Орша",
            "Лида",
        };
        private readonly string[] COMBOBOX_VALUES_TYPE_OF_DEPOSIT = {
            "срочные сберегательные вклады",
            "накопительные вклады",
            "вклады до востребования",
            "мультивалютные депозиты",
            "специализированные депозиты",
            "депозиты в драгметаллах"
        };
        public static ObservableCollection<Owner> ownersCollections { get; set; } = new ObservableCollection<Owner>();
        public Bank()
        {
            InitializeComponent();
            Serializator.Deserialize();
            CenterToScreen();
            CityComboBox.DataSource = COMBOBOX_VALUES_CITY;
            TypeOfDepositСomboBox.DataSource = COMBOBOX_VALUES_TYPE_OF_DEPOSIT;

            DataGridViewForOwner.Visible = false;
            FormAccount.Visible = false;
            FormHistory.Visible = false;
            FormOwner.Visible = true;
        }
        
        private void NextButtonClick(object sender, EventArgs e)
        {            
            if (ValidateFailure())
            {
                State++;
                GoToNextForm();
            }
        }
        private void GoToNextForm()
        {
            switch (State)
            {
                case 2:
                    {
                        FormOwner.Visible = false;
                        FormAccount.Visible = true;
                        break;
                    }
                case 3:
                    {
                        FormAccount.Visible = false;
                        FormHistory.Visible = true;
                        break;
                    }
                default:
                    FormHistory.Visible = false;
                    NextButton.Visible = false;
                    SaveChangesForInstance();
                    DataGridViewForOwner.DataSource = ownersCollections;
                    DataGridViewForOwner.Visible = true;
                    break;
            }
        }
        private bool ValidateFailure()
        {
            switch (State)
            {
                case 1: return !ValidateFormForOwner();
                case 2: return !ValidateFormForAccount();
                case 3: return !ValidateFormForHistory();
                default: return true;
            }
        }
        private bool ValidateFormForOwner()
        {
            List<bool> bools = new List<bool>() {
                Validatator.Text(ref FirstNameTextBox),
                Validatator.Text(ref LastNameTextBox),
                Validatator.Text(ref PatronymicTextBox),
                Validatator.Combo(ref CityComboBox, COMBOBOX_VALUES_CITY),
                Validatator.Date(ref DateOfBirthDateTimePicker),
                Validatator.Number(ref HouseTextBox),
            };
            DateOfBirthDateTimePicker.Invalidate();
            return bools.Any(x => x == false);
        }
        private bool ValidateFormForAccount()
        {
            List<bool> bools = new List<bool>() {
                Validatator.Number(ref IDTextBox),
                Validatator.Number(ref AmountAccountTextBox),
                Validatator.Combo(ref TypeOfDepositСomboBox, COMBOBOX_VALUES_TYPE_OF_DEPOSIT),
                Validatator.Date(ref DateOpeningDateTimePicker)
            };
            return bools.Any(x => x == false);
        }
        private bool ValidateFormForHistory()
        {
            List<bool> bools = new List<bool>() {
                Validatator.Number(ref AmountHistoryTextBox),
                Validatator.Date(ref DateOpeningDateTimePicker)
            };
            return bools.Any(x => x == false);
        }
        private void SaveChangesForInstance()
        {
            Owners owners = new Owners();
            InitOwner();

            owners.owners.Add(Instance);
            
            Serializator.Serialize(owners);    
        }
        private void InitOwner()
        {
            Instance = new Owner(
                new Account()
                {
                    Id = Convert.ToInt64(IDTextBox.Text),
                    SmsAlerts = SmsAlertsCheckBox.Checked,
                    Balance = Convert.ToDecimal(AmountAccountTextBox.Text),
                    OpeningDate = DateTime.Parse(DateOpeningDateTimePicker.Text),
                    TypeOfDeposit = TypeOfDepositСomboBox.SelectedItem.ToString(),
                },
                new HistoryOfOperations()
                {
                    TypeOfOperation = (TypeUPRadioButton.Checked == true ? "Пополнение" : "Трата средств"),
                    Amount = Convert.ToDecimal(AmountHistoryTextBox.Text),
                    Date = DateTime.Parse(DateOfTheEventDateTimePicker.Text),
                }
              )
            {
                City = CityComboBox.Text,
                House = HouseTextBox.Text,
                LastName = LastNameTextBox.Text,
                FirstName = FirstNameTextBox.Text,
                Patronymic = PatronymicTextBox.Text,
                DateOfBirth = DateTime.Parse(DateOfBirthDateTimePicker.Text),
            };
        }
    }
}
