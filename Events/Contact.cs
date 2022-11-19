using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events;
public class Contact
{   
    public delegate void ContactEventHandler(object sender, EventArgs eventArgs);

    public event ContactEventHandler FullNameChanged;

    public event ContactEventHandler PhoneNumberChanged;

    public event ContactEventHandler AddressChanged;

    private string _fullName;

    private string _phoneNumber;

    private string _address;

    public string FullName
    {
        get => _fullName;
        set
        {
            if (_fullName != value)
            {
                _fullName = value;
                FullNameChanged.Invoke(value, EventArgs.Empty);
            }
        }
    }

    public string PhoneNumber
    {
        get => _phoneNumber;
        set
        {
            if (_phoneNumber != value)
            {
                _phoneNumber = value;
                PhoneNumberChanged.Invoke(value, EventArgs.Empty);
            }
        }
    }

    public string Address
    {
        get => _address;
        set
        {
            if (_address != value)
            {
                _address = value;
                AddressChanged.Invoke(value, EventArgs.Empty);
            }
        }
    }
}
