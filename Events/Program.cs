using System.ComponentModel;

namespace Events
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Contact contact = new();

            EventForm firstForm = new();
            firstForm.Contact = contact;
            firstForm.Text = "FirstForm";
            firstForm.Show();
            firstForm.Location = new Point(200, 200);

            EventForm secondForm = new();
            secondForm.Contact = contact;
            secondForm.Text = "SecondForm";
            secondForm.Show();
            secondForm.Location = new Point(550, 200);

            EventForm thirdForm = new();
            thirdForm.Contact = contact;
            thirdForm.Text = "ThirdForm";
            thirdForm.Show();
            thirdForm.Location = new Point(900, 200);

            Application.Run(firstForm);
        }
    }
}