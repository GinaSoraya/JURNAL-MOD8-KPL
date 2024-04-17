using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_1302223070
{
    class UIConfig
    {
        public bank_transfer_config config;
        public const String filePath = @"C:\\GINA\\KULIAH\\SEMESTER 4\\KONTRUKSI PERANGKAT LUNAK\\PRAKTIKUM\\MINGGU 8\\modul8_1302223070\\modul8_1302223070\\bank_transfer_config.json";
        public UIConfig()
        {
            try
            {
                ReadConfigFile();
            } 
            catch (Exception) 
            {
                SetDefault();
                WriteConfigFile();
            }
        }
        public bank_transfer_config ReadConfigFile()
        {
            string configJson = File.ReadAllText(filePath);
            config = JsonSerializer.Deserialize<bank_transfer_config>(configJson);
            return config;
        }
        public void SetDefault()
        {
            config.tf= new bank_transfer_config.transfer(config.tf.threshold, config.tf.low_fee, config.tf.high_fee);
            config.konfirmasi = new bank_transfer_config.confirmation(config.konfirmasi.en, config.konfirmasi.id);
            config.lang = "en";
            config.tf.threshold = 25000000;
            config.tf.low_fee = 6500;
            config.tf.high_fee = 15000;
            config.methods = ["RTO (real-time)", "SKN", "RTGS", "BI FAST"];
            config.konfirmasi.en = "yes";
            config.konfirmasi.id = "ya";
        }
        private void WriteConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filePath, jsonString);    
        }
    }
}
