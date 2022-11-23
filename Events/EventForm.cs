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
        fullNameTextBox.Text = Contact.FullName;
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
    
    // TODO: RSDN+
    private void CloseButton_Click(object sender, EventArgs e)
    {
        Contact.FullNameChanged -= ContactFullNameChanged;
        Contact.PhoneNumberChanged -= ContactPhoneNumberChanged;
        Contact.AddressChanged -= ContactAddressChanged;
        Close();
    }

    private void EventForm_Load(object sender, EventArgs e)
    {
		// TODO: перенести подписку событий в сеттер свойства.
		// Также учесть, что если прошлое значение свойства не равно null,
		// то отписать прошлое значение от событий.
		Contact.FullNameChanged += ContactFullNameChanged;
        Contact.PhoneNumberChanged += ContactPhoneNumberChanged;
        Contact.AddressChanged += ContactAddressChanged;
    }

    // TODO: RSDN+
	private void FullnameTextBox_TextChanged(object sender, EventArgs e)
    {
        Contact.FullName = fullNameTextBox.Text;
    }

	// TODO: RSDN+
	private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
    {
        Contact.PhoneNumber = phoneNumberTextBox.Text;
    }

	// TODO: RSDN+
	private void AddressTextBox_TextChanged(object sender, EventArgs e)
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