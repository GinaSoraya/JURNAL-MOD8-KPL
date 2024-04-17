using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul8_1302223070
{
    internal class bank_transfer_config
    {
        public string lang {  get; set; }
        public transfer tf { get; set; }
        public string[] methods { get; set; }
        public confirmation konfirmasi { get; set; }
        public class transfer
        {
            public transfer(int threshold, int low_fee, int high_fee)
            {
                this.threshold = 0;
                this.low_fee = 0;
                this.high_fee = 0;
            }
            public int threshold { get; set; }
            public int low_fee { get; set; }
            public int high_fee { get; set; }
        }
        public class confirmation
        {
            public string en { get; set; }
            public string id { get; set; }
            public confirmation(string en, string id) 
            {
                this.en = en;
                this.id = id;
            }
        }
    }
}
