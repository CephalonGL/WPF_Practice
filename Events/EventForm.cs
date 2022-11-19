namespace Events;

/// <summary>
/// Form for events.
/// </summary>
public partial class EventForm : Form
{
    /// <summary>
    /// Stores contact.
    /// </summary>
    public Contact Contact 
    {
        get;
        set;
    }

    /// <summary>
    /// Update text box for full name case it is changed in contact.
    /// </summary>
    /// <param name="sender">Event sender.</param>
    /// <param name="e">Event argument.</param>
    private void ContactFullNameChanged(object sender, EventArgs e)
    {
        fullnameTextBox.Text = Contact.FullName;
    }

    /// <summary>
    /// Update text box for phone number case it is changed in contact.
    /// </summary>
    /// <param name="sender">Event sender.</param>
    /// <param name="e">Event argument.</param>
    private void ContactPhoneNumberChanged(object sender, EventArgs e)
    {
        phoneNumberTextBox.Text = Contact.PhoneNumber;
    }
    
    /// <summary>
    /// Update text box for address case it is changed in contact.
    /// </summary>
    /// <param name="sender">Event sender.</param>
    /// <param name="e">Event argument.</param>
    private void ContactAddressChanged(object sender, EventArgs e)
    {
        addressTextBox.Text = Contact.Address;
    }
    
    public EventForm()
    {
        InitializeComponent();
    }
    
    private void closeButton_Click(object sender, EventArgs e)
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