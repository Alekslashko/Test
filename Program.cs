class Program
{
    public static void Main(string[]arg)
    {
        decimal balance = 100;

        Thread clientThread = new Thread(() =>
        {
            for (int i = 0; i < 3; i++)
            {
                decimal amountToWithdraw = 300;
                Console.WriteLine($"Клиент иска да изтегли {amountToWithdraw} лв.");
                if (amountToWithdraw <= balance)
                {
                    balance -= amountToWithdraw;
                    Console.WriteLine($"Клиент успешно изтегли {amountToWithdraw} лв.");
                }
                else {Console.WriteLine($"Клиент не може да изтегли {amountToWithdraw} лв. тъй като има {balance} лв.");}
            }
        });

        Thread bankEmployeeThread = new Thread(() =>
        {
            for (int i = 0; i < 3; i++)
            {
                decimal amountToDeposit = 200;
                balance += amountToDeposit;
                Console.WriteLine($"Банков служител добави {amountToDeposit}");
            }
        });

    clientThread.Start();


    }
}