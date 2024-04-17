using modul8_1302223070;

internal class Program
{
    private static void Main(string[] args)
    {
        bank_transfer_config config = new bank_transfer_config();   
        UIConfig uiConfig = new UIConfig();
        int input;
        int biaya;

        uiConfig.ReadConfigFile();
        if (uiConfig.config.lang == "en")
        {
            Console.WriteLine($"Please insert the amount of money to transfer {input}");
            if (input <= uiConfig.config.tf.threshold) {
                biaya = uiConfig.config.tf.low_fee;
                Console.WriteLine($"Transfer fee = {biaya}");
                Console.WriteLine($"Total biaya = {input + biaya}");
            } 
            else
            {
                biaya =  uiConfig.config.tf.high_fee;
                Console.WriteLine($"Transfer fee = {biaya}");
                Console.WriteLine($"Total biaya = {input + biaya}");
            }
        }
        else
        {
            Console.WriteLine($"Masukan jumlah uang yang akan di-transfer {input}");
            if (input <= uiConfig.config.tf.threshold)
            {
                biaya = uiConfig.config.tf.low_fee;
                Console.WriteLine($"Biaya transfer = {biaya}");
                Console.WriteLine($"Total biaya = {input + biaya}");
            }
            else
            {
                biaya = uiConfig.config.tf.high_fee;
                Console.WriteLine($"Biaya transfer = {biaya}");
                Console.WriteLine($"Total biaya = {input + biaya}");
            }
        }

    }
}