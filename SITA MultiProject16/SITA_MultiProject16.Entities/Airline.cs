using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace SITA_MultiProject16.Entities
{
    public partial class Airline
    {       
        
    
        public int Id { get; set; }
public string Name { get; set; }
public string Description { get; set; }
public string AirlineATACode { get; set; }
public int GlobalManagementAirportId { get; set; }
public string Topic { get; set; }
public string TopicComunicationString { get; set; }
public string PrimaryContactNumber { get; set; }
public string PrimaryContactName { get; set; }
public string Email { get; set; }
public string Fax { get; set; }
public int IsCinfigured { get; set; }
    
        
    }
}