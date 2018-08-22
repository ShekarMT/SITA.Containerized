using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace SITA_MultiProject16.Entities
{
    public partial class Region
    {       
        
    
        public int Id { get; set; }
public string Name { get; set; }
public string PrimaryRegionUrlription { get; set; }
public string Description { get; set; }
public string ServiceUrl { get; set; }
public int FailoverRegion { get; set; }
public string FailoverRegionUrl { get; set; }
    
        
    }
}