using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab02
{
    [Serializable]
    public abstract class IHistoryOfOperations
    {
        public string TypeOfOperation { get; set; }
        public decimal Amount {get; set; }
        public DateTime Date { get; set; }
    }
    [Serializable]
    public class HistoryOfOperations : IHistoryOfOperations
    {

    }
}
