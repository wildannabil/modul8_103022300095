using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_103022300095
{
    internal class BankTransferConfig
    {
        public const string filepath = "bank_transfer_config.json";
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
        public BankTransferConfig()
        {
            threshold = 25000000;
            low_fee = 6500;
            high_fee = 15000;
        }
    }

    class UIConfig
    {
        public BankTransferConfig bankTransferConfig;
        public const String filePath = @"config.json";
        public UIConfig() {  }
        private Config ReadConfigFile() { … }D
        private void SetDefault() { … }
        private void WriteNewConfigFile() { … }

    }
}
