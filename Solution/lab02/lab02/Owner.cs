using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace lab02
{
    [Serializable]
    [XmlInclude(typeof(IAccount))]
    [XmlInclude(typeof(Account))]
    [XmlInclude(typeof(IHistoryOfOperations))]
    [XmlInclude(typeof(HistoryOfOperations))]
    public class Owners
    {
        public Owners() { }
        public List<Owner> owners { get; set; } = new List<Owner>();
    }

    [Serializable]
    public class Owner
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Patronymic { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; } = new DateTime();
        public string City { get; set; } = string.Empty;
        public string House { get; set; } = string.Empty;


        public IAccount Account { get; set; }
        public IHistoryOfOperations HistoryOfOperations { get; set; }
        public Owner() { }
        public Owner(IAccount Account, IHistoryOfOperations HistoryOfOperations)
        {
            this.Account = Account;
            this.HistoryOfOperations = HistoryOfOperations;
        }
    }
}
