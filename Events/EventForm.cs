namespace Events;

public partial class EventForm : Form
{
    

    public Contact Contact 
    {
        get;
        set;
    }

    private void ContactFullNameChanged(object sender, EventArgs e)
    {
        fullnameTextBox.Text = Contact.FullName;
    }

    private void ContactPhoneNumberChanged(object sender, EventArgs e)
    {
        phoneNumberTextBox.Text = Contact.PhoneNumber;
    }

    private void ContactAddressChanged(object sender, EventArgs e)
    {
        addressTextBox.Text = Contact.Address;
    }

    public EventForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Contact.FullNameChanged -= ContactFullNameChanged;
        Contact.PhoneNumberChanged -= ContactPhoneNumberChanged;
        Contact.AddressChanged -= ContactAddressChanged;
        Close();
    }

    private void EventForm_Load(object sender, EventArgs e)
    {
        Contact.FullNameChanged += ContactFullNameChanged;
        Contact.PhoneNumberChanged += ContactPhoneNumberChanged;
        Contact.AddressChanged += ContactAddressChanged;
    }

    private void fullnameTextBox_TextChanged(object sender, EventArgs e)
    {
        Contact.FullName = fullnameTextBox.Text;
    }

    private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
    {
        Contact.PhoneNumber = phoneNumberTextBox.Text;
    }

    private void addressTextBox_TextChanged(object sender, EventArgs e)
    {
        Contact.Address = addressTextBox.Text;
    }

    private void EventForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        Contact.FullNameChanged -= ContactFullNameChanged;
        Contact.PhoneNumberChanged -= ContactPhoneNumberChanged;
        Contact.AddressChanged -= ContactAddressChanged;
    }
}