using Fællessystem.Model;
using Fællessystem.Persistence;
using Fællessystem.ViewModel.EventArgs;
using System.ComponentModel;
using System.Windows.Input;

namespace Fællessystem.Handlers
{

    public delegate NewVolunteerApplicationEventArgs NewVolunteerApplicationEventHandler(object sender, NewVolunteerApplicationEventArgs args);
    public class NewVolunteerApplicationHandler
    {
        public ICommand ConfirmCmd { get; } = FactoryCommands.CreateConfirmCmd();

        public event NewVolunteerApplicationEventHandler NewVolunteerApplicationRequested;

        private VolunteerApplicationRepository volunteerApplicationRepo;

        public NewVolunteerApplicationHandler()
        {
            volunteerApplicationRepo = FactoryRepositories.CreateVolunteerAplicationRepository();
        }

        // Creates an VolunteerApplication object with a comment attribute, for each area chosen in the View
        public bool CreateNewVolunteerApplication(Member member)
        {
            NewVolunteerApplicationEventArgs e = OnNewVolunteerApplicationRequested();
            if (e != null)
            {
                VolunteerApplication newVolunteerApplication;
                for (int i = 0; i < e.AreaList.Count; i++)
                {
                    newVolunteerApplication = FactoryModels.CreateVolunteerApplication(member.MemberID, e.AreaList[i], e.CommentList[i]);
                    _ = volunteerApplicationRepo.Add(newVolunteerApplication); //Saves the application in the database
                }

                FactoryMessages.CreateMessageBox("Tak for din ansøgning", "Ansøgning sendt");

                return true;
            }
            return false;
        }

        protected NewVolunteerApplicationEventArgs OnNewVolunteerApplicationRequested()
        {
            NewVolunteerApplicationEventArgs result = null; //Creating result
            NewVolunteerApplicationEventHandler newVolunteerApplicationRequested = NewVolunteerApplicationRequested;  //

            if (NewVolunteerApplicationRequested != null)
            {
                NewVolunteerApplicationEventArgs args = null; //Creating args
                result = newVolunteerApplicationRequested(this, args);
            }
            return result;
        }

    }
}
