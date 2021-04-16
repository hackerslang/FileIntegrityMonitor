using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIntegrityMonitor.DTO
{
   public class FileScanError
    {
        public byte Id { get; set; }
        public int ErrorCode { get; set; }
        public string Caption { get; set; }
        public string ErrorMessage { get; set; }
    }
}
