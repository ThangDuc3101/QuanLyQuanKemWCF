using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFBanKem
{
    [DataContract]
    public class Ice_cream
    {
        [DataMember]
        [Required(ErrorMessage = "Id không thể trống")]
        public int Id { set; get; }

        [DataMember]
        public string Name { set; get; }

        [DataMember]
        public decimal price { set; get; }

        [DataMember]
        public int numberorder { set; get; }
        
    }
}
