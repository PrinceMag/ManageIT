using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BaseLibrary.DTOs
{
    public record CustomUserClaims(string Id = null!,string Name = null!,string Email = null!,string Role = null!);
}
