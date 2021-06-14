using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades.Modelos
{
    [DataContract]
    public class TransactionResult
    {
        [DataMember]
        public bool IsOk { get; set; }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Error { get; set; }

        public override string ToString()
        {
            string b = IsOk ? "Ok" : "Err";
            return $"{b} - {Id} - {Error}";
        }
    }


}
