// See https://aka.ms/new-console-template for more information
            Individuo individuo1 = new Individuo("Marco", 1.69, 60);
            
            Console.WriteLine("Nome: " + individuo1.Nome + " " + "Peso: " + individuo1.Peso + " " + "Altura: " + individuo1.Altura + " " +  "IMC: " + individuo1.Imc);

            if (individuo1.Imc < 17)
                Console.WriteLine("Muito abaixo do peso");
            else if (individuo1.Imc >= 17 && individuo1.Imc <= 18.49)
                Console.WriteLine("Abaixo do peso");
            else if (individuo1.Imc >= 18.50 && individuo1.Imc <= 24.99)
                Console.WriteLine("Peso normal");
            else if (individuo1.Imc >= 25 && individuo1.Imc <= 29.99)
                Console.WriteLine("Acima do peso");
            else if (individuo1.Imc >= 30 && individuo1.Imc <= 34.99)
                Console.WriteLine("Obesidade I");
            else if (individuo1.Imc >= 35 && individuo1.Imc <= 39.99)
                Console.WriteLine("Obesidade II (severa)");
            else if (individuo1.Imc >= 40)
                Console.WriteLine("Obesidade III (mórbida)");
            
            
            if (individuo1.Imc < 18.50) 
            {
                individuo1.PesoGanhar;
                Console.WriteLine("Massa necessária para o peso normal (IMC 18,50): " + individuo1.Massa);
                Console.WriteLine("Massa necessária a ganhar para chegar ao peso normal (IMC 18,50): " + individuo1.PesoGanharPerder);
            } else if (individuo1.Imc > 24.99)
            {
                individuo1.PesoPerder;
                Console.WriteLine("Massa necessária para o peso normal (IMC 24.99): " + individuo1.Massa);
                Console.WriteLine("Massa necessária a perder para chegar ao peso normal (IMC 24.99): " + individuo1.pesoGanharPerder);
            }

