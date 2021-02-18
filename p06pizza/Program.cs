using System;

namespace _6pizza
{
    class Program
    {
        static int Main(string[] args)
        {
            char tam, cub, don;
            string tamaño="", ingredientes="", cubierta, donde;
            string[] ings;

            if(args.Length==0){
                Menu();
                return 1;
            }
            //elegir tamaño
            tam = Char.Parse(args[0].ToUpper());
            if(tam == 'P'){
                tamaño = "Pequeña";
            }else if(tam == 'M'){
                tamaño = "Mediana";
            }else{
                tamaño = "Grande";
            }

            //Elegir ingredientes
            ings = args[1].Split("+");
            foreach(string i in ings){
                switch(char.Parse(i.ToUpper())){
                    case 'E': ingredientes+= "ExtraQueso "; break;
                    case 'C': ingredientes+= "Champiñones "; break;
                    case 'P': ingredientes+= "Piña "; break;
                }
            }

            //Tipo de cubierta
            cub = Char.Parse(args[2].ToUpper());
            cubierta = (cub=='D' ? "Delgada":"Gruesa");

            //Donde la consume
            don = Char.Parse(args[3].ToUpper());
            donde = (don == 'A' ? "Aqui": "Llevar");

            //Resultado del pedido
            Console.WriteLine("Tu pizza quedo integrada de la siguiente manera \n");
            Console.WriteLine("Tamaño {0}",tamaño);
            Console.WriteLine("Tamaño {0}",ingredientes);
            Console.WriteLine("Cubierta {0}",cubierta);
            Console.WriteLine("Consume {0}",donde   );


            return 0;
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("\nElije como deseas armar tu pedido de pizza");
            Console.WriteLine("Tamaño: [P]equeña  [M]ediana  [G]rande");
            Console.WriteLine("Ingredientes: [E]xtra queso  [C]hampiñones  [P]iña \n Unidos por un +");
            Console.WriteLine("Cubierta: [D]elgada  [G]ruesa");
            Console.WriteLine("Donde la consumes: [A]qui  [L]levar");
        }
    }
}
