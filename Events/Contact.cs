using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events;
/// <summary>
/// Stores info about contact.
/// </summary>
public class Contact
{   
	// TODO: По заданию нужно использовать встроенный EventHandler.
    /// <summary>
    /// Delegate for events.
    /// </summary>
    /// <param name="sender">Event sender.</param>
    /// <param name="eventArgs">Event arguments.</param>
    public delegate void ContactEventHandler(object sender, EventArgs eventArgs);

    // TODO: События должны идти после свойств.
    /// <summary>
    /// Invoke case full name changes.
    /// </summary>
    public event ContactEventHandler FullNameChanged;

    /// <summary>
    /// Invoke case phone number changes.
    /// </summary>
    public event ContactEventHandler PhoneNumberChanged;

    /// <summary>
    /// Invoke case address changes.
    /// </summary>
    public event ContactEventHandler AddressChanged;

    /// <summary>
    /// Stores full name.
    /// </summary>
    private string _fullName;

    /// <summary>
    /// Stores phone number.
    /// </summary>
    private string _phoneNumber;

    /// <summary>
    /// Stores address.
    /// </summary>
    private string _address;

    /// <summary>
    /// Property for full name.
    /// </summary>
    public string FullName
    {
        get => _fullName;
        set
        {
            if (_fullName != value)
            {
                _fullName = value;
                // TODO: проверка события на null. 
                FullNameChanged.Invoke(value, EventArgs.Empty);
            }
        }
    }
    /// <summary>
    /// Property for phone number.
    /// </summary>
    public string PhoneNumber
    {
        get => _phoneNumber;
        set
        {
            if (_phoneNumber != value)
            {
                _phoneNumber = value;
                // TODO: проверка события на null. 
				PhoneNumberChanged.Invoke(value, EventArgs.Empty);
            }
        }
    }
    /// <summary>
    /// Property for address.
    /// </summary>
    public string Address
    {
        get => _address;
        set
        {
            if (_address != value)
            {
                _address = value;
                // TODO: проверка события на null. 
				AddressChanged.Invoke(value, EventArgs.Empty);
            }
        }
    }
}
