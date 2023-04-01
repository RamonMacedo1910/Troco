// See https://aka.ms/new-console-template for more information
Console.WriteLine("***Quanto deu o troco?***");

Console.WriteLine();

decimal dinheiro, ValorTotal, troco;

        Console.Write("Por favor, digite o valor da compra: R$");
        ValorTotal = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Por favor, digite o valor pago: R$");
                dinheiro = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Valor do seu troco: ");
                troco = dinheiro - ValorTotal;

                Console.WriteLine($"{troco:C}");

                Console.WriteLine();                
                
                Console.WriteLine("***Obrigado, e volte sempre.***");
             