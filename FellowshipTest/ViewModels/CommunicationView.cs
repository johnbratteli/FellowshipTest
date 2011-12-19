using System.ComponentModel.DataAnnotations;
using FellowshipTest.Models;

namespace FellowshipTest.ViewModels
{
    public class CommunicationView
    {
        public Communication Comm { get; set; }

        public CommunicationView()
        {
            Comm = new Communication();
        }

        public CommunicationView(string personID, string personURI, communicationType type, communicationGeneralType gType)
        {
            Comm = new Communication(personID, personID, type, gType);
        }
        
        public static explicit operator CommunicationView(Communication comm)
        {
            var personID = comm.person.id;
            var personURI = comm.person.uri;
            var type = comm.communicationType;
            var gType = comm.communicationGeneralType;

            return new CommunicationView(personID, personURI, type, gType);
        }
    }
}