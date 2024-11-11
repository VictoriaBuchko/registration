namespace registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ButtonRegistration_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxName.Text))
            {
                MessageBox.Show("���� �����, ������ ��'�", "�������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxLastName.Text))
            {
                MessageBox.Show("���� �����, ������ �������", "�������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxEmail.Text) || !TextBoxEmail.Text.Contains("@"))
            {
                MessageBox.Show("���� �����, ������ �������� ���������� �����", "�������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxPhone.Text) || TextBoxPhone.Text.Length < 10)
            {
                MessageBox.Show("���� �����, ������ ��������� ����� �������� (����� 10 �������)", "�������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ComboBoxEvent.SelectedIndex == -1)
            {
                MessageBox.Show("���� �����, ������ ��� ��䳿", "�������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!RadioButtonOnline.Checked && !RadioButtonOffline.Checked)
            {
                MessageBox.Show("���� �����, ������ ������ ����� (������ ��� ������)", "�������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CheckBoxYes.Checked)
            {
                MessageBox.Show("�� ������ ���������� � ������� �����!", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = TextBoxName.Text;
            string lastName = TextBoxLastName.Text;
            string email = TextBoxEmail.Text;
            string phone = TextBoxPhone.Text;
            string eventType = ComboBoxEvent.SelectedItem?.ToString() ?? "�� ������";
            DateTime selectedDate = MonthCalendarDate.SelectionStart;
            DateTime selectedTime = DateTimePickerTime.Value;
            string format = RadioButtonOnline.Checked ? "������" : "������";

            string message = $"��'�: {name}\n�������: {lastName}\n���������� �����: {email}\n�������: {phone}\n" +
                             $"��� ��䳿: {eventType}\n����: {selectedDate.ToShortDateString()}\n���: {selectedTime.ToShortTimeString()}\n" +
                             $"������ �����: {format}";

            MessageBox.Show(message, "ϳ����������� ���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxName.Clear();
            TextBoxLastName.Clear();
            TextBoxEmail.Clear();
            TextBoxPhone.Clear();
            ComboBoxEvent.SelectedIndex = -1;
            MonthCalendarDate.SetDate(DateTime.Today);
            DateTimePickerTime.Value = DateTime.Now;
            RadioButtonOnline.Checked = false;
            RadioButtonOffline.Checked = false;
            foreach (int i in CheckedListBoxTopic.CheckedIndices)
            {
                CheckedListBoxTopic.SetItemChecked(i, false);
            }
            CheckBoxYes.Checked = false;
            CheckBoxNo.Checked = false;
        }

        private void CheckBoxYes_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxYes.Checked)
            {
                CheckBoxNo.Checked = false;
            }
        }

        private void CheckBoxNo_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxNo.Checked)
            {
                CheckBoxYes.Checked = false;
            }
        }
    }
}
