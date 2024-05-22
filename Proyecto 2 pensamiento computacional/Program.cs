
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices.Marshalling;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using Proyecto_2_pensamiento_computacional;

class Program {
      
    public static void Main(String[] args) 
    {

     Tablero tablero = new Tablero();

        Console.WriteLine("    Ingrese el numero de piezas que desea posicionar         ");
        int npiezas = Convert.ToInt32(Console.ReadLine());
        Pieza Cpiezas = new Pieza();
        string color = " ";

         // Crear un arreglo para guardar el numero de piezas que desea   
        string [] piezas = new string[npiezas];

    // Recorrer el arreglo para el numero de piezas
        for (int i = 0; i<npiezas; i++)

        {
            //Pedir la pieza y luego repetir el procedimeinto por cada pieza y el valor de i aumentara indicando que el numero de la pieza es diferente
            Console.WriteLine("                                                                     ");
            Console.WriteLine(" --------------------------------------------------------------------");
            Console.Write("Pieza No.: ");
            Console.WriteLine(i+1);
            Console.WriteLine("                             Tipos de piezas                 "); 
            Console.WriteLine ("1. Rey");
            Console.WriteLine ("2. Alfil"); 
            Console.WriteLine ("3. Peon");
            Console.WriteLine ("4. Caballo");
            Console.WriteLine ("5. Torre");
            Console.WriteLine ("                                                            ");
            Console.WriteLine ("               Ingrese el numero de la pieza que desee      ");
            int tipo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("                                                                     ");
            Console.WriteLine(" --------------------------------------------------------------------");
            Console.WriteLine ("                                                        ");
            Console.WriteLine ("                        Color de piezas                 ");
            Console.WriteLine("                   Ingrese el color de la pieza           ");
            Console.WriteLine ("1. Blanco");
            Console.WriteLine ("2. Negro"); 
                        
        
            Console.WriteLine ("Ingrese el numero de la opcion de color que desea para la pieza  " + Convert.ToString(i+1));
            int respuesta = Convert.ToInt32(Console.ReadLine());
            if(respuesta ==1 || respuesta ==2){

           // Estos datos se pasan a Cpiezas
            switch (respuesta)
            {
                case 1:
                color = "B";
                break;

                case 2:
                color = "N";
                break;
            }
            
            Console.WriteLine("Ingrese el Numero de la fila en el tablero para la pieza   " + Convert.ToString(i+1));
            int fila = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Ingrese la letra de la columna en el tablero para la pieza  " + Convert.ToString(i+1));
            string columna = Console.ReadLine();
            

            switch (tipo)
            {
                case 1:
                // dato proporcionado por el switch con los datos de tipo y color
                Cpiezas = new Pieza(color, "Rey");
                //Pasar los datos de fila y columna que el usurio ingreso
                Cpiezas.Posicionar(fila,columna); 
                //Posicionar pieza y guardar todo (color y tipo) en Tipo pieza
                tablero.PosicionPieza(color + Cpiezas.Tipopieza, Cpiezas.Fila, Cpiezas.Columna);
                break;

                case 2:
                Cpiezas = new Pieza(color, "Alfil");
                //Pasar los datos de fila y columna que el usurio ingreso
                Cpiezas.Posicionar(fila,columna); 
                //Posicionar pieza
                tablero.PosicionPieza(color + Cpiezas.Tipopieza, Cpiezas.Fila, Cpiezas.Columna);
                break;

                case 3:
                Cpiezas = new Pieza(color, "Peon");
                //Pasar los datos de fila y columna que el usurio ingreso
                Cpiezas.Posicionar(fila,columna); 
                //Posicionar pieza
                tablero.PosicionPieza(color + Cpiezas.Tipopieza, Cpiezas.Fila, Cpiezas.Columna);
                break;

                case 4:
                Cpiezas = new Pieza(color, "Caballo");
                //Pasar los datos de fila y columna que el usurio ingreso
                Cpiezas.Posicionar(fila,columna); 
                //Posicionar pieza
                tablero.PosicionPieza( color + Cpiezas.Tipopieza, Cpiezas.Fila, Cpiezas.Columna);
                break;

                case 5:
                Cpiezas = new Pieza(color, "Torre");
                //Pasar los datos de fila y columna que el usurio ingreso
                Cpiezas.Posicionar(fila,columna); 
                //Posicionar pieza
                tablero.PosicionPieza( color + Cpiezas.Tipopieza, Cpiezas.Fila, Cpiezas.Columna);
                break;
            }


            }
            Console.WriteLine("                                                                     ");
            tablero.MostrarPosiciones();


        //Mostrar posiciones para la reina
            Console.WriteLine("                                                                     ");
            Console.WriteLine(" --------------------------------------------------------------------");
            Console.WriteLine("                Posicion pieza dama                                 ");
            Console.WriteLine("           Ingrese el color para la reina                       ");
            Console.WriteLine ("1. Blanco");
            Console.WriteLine ("2. Negro");
            Console.WriteLine(" Elija la opcion que desea:  ");

            //Guardar el color de la pieza
            int res = Convert.ToInt32(Console.ReadLine());
            //Creación de un switch para las opciones de color
            switch (res)
            {
            case 1:
            color = "B";
                break;

            case 2:
            color = "N";
            break;
            }
            //El tablero de pasa el dato del color de la dama
            tablero.colorDama = color;

            // Verificar con un bucle si es posible validar la posicion de la dama
            bool autorizacion = true;
             
            do
        {
            tablero.piezas = " ";
            Console.WriteLine("Ingrese el numero de la fila en el tablero para la dama                ");
            int filas = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Ingrese la letra de la columna en el tablero para la dama             " );
            string columnas = Console.ReadLine();


            Cpiezas=new Pieza(color, "Dama");
            Cpiezas.Posicionar(filas,columnas);
            tablero.PosicionPieza(Cpiezas.Tipopieza,Cpiezas.Fila, Cpiezas.Columna);
            // llamar a la funcion poscionar dama
            autorizacion = tablero.PosicionarDama();
           
            //Comprobar si el tablero no encontro otra pieza
            if(tablero.piezas != "")
            {
            // de lo contrario, si la posicion no es valida
                Console.WriteLine("No se puede agregar la dama en esta posicion");
                Console.WriteLine(tablero.piezas);
                autorizacion = true;
            }
            else
            {
                // retornar la posicion de la dama

                autorizacion = false;
                Console.WriteLine("Posicion valida");
                

            }
        }while(autorizacion== true);    


    }
}
}
