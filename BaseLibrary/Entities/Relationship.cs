using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Relationship
    {

        //Relationshhip One to Many
        [JsonIgnore]

        public List<Employee>? Employee { get; set; }
    }
}
