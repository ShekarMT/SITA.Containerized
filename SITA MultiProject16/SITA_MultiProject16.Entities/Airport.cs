using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace SITA_MultiProject16.Entities
{
    public partial class Airport
    {       
        
    
        public int Id { get; set; }
public string Name { get; set; }
public string Description { get; set; }
public string AirportATACode { get; set; }
public string PrimaryContactName { get; set; }
public string PrimaryContactNumber { get; set; }
public string AlternateContactNumber { get; set; }
public string Email { get; set; }
public string Fax { get; set; }
    
        
    }
}