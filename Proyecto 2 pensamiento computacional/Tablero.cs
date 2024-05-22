using System.Security.Cryptography.X509Certificates;

namespace Proyecto_2_pensamiento_computacional;

public class Tablero
{
   
    public string [,] tablero = new string [8,8];

    // Para guardar las filas y columnas de la dama
    public  int Pfila;
    public int  Pcolumna;

    // Convertir piezas en un atributo de la clase para guardar y luego hacer la validacion
    public string piezas;
    public string colorDama = " ";


//Imprimir que la matriz tenga las posiciones vacias
// Antes de ingresar la cantidad de piezas, tipo y color; se 
//metodo constructor
    public Tablero()
    {
        // Inicialicar el atributo piezas
        this.piezas = "";
        // Recorrer todo el contenido de la matriz para que al ingresar la pieza y su posicion el tablero tenga todo ocupado como vacio
        for (int i = 0; i<=7; i++) 
        {

            for(int j = 0; j<=7; j++)
            {
                tablero[i,j]= "vacio";
            }
        }
    }

//metodo para mostrar que es el contenido del tablero

    public void MostrarPosiciones ()
    {
        int valori;
        string valorj = " ";

       for (int i = 0; i<=7; i++) 
        {

            for(int j = 0; j<= 7; j++)
            {
                valori = i+1;
                    
                switch (j)
                {
                    case 0:
                    valorj = "A";
                    break;

                    case 1:
                    valorj = "B";
                    break;

                    case 2:
                    valorj = "C";
                    break;

                    case 3:
                    valorj = "D";
                    break;

                    case 4:
                    valorj = "E";
                    break;

                    case 5:
                    valorj = "F";
                    break;

                    case 6:
                    valorj = "G";
                    break;

                    case 7:
                    valorj = "H";
                    break;
                }

                //Nos dice donde vamos a posicionar la pieza
                Console.Write(valorj + valori);
                // Para que el resultado lo imprima en la misma linea y mostrar el valor que tiene en el tablero
                 // Ej. en la poscion [0,0] = vacio
                Console.Write(" " + tablero[i,j]);
            }     
             Console.WriteLine(" ");

        }
    }

    //Definir los parametros
    public void PosicionPieza (string tipo, int fila, int columna)
    {
        
        // se hace la referencia el dato anterior para posicionar la pieza donde el usuario lo desee
        // se inserta el tipo de pieza
        // En que fila y en que columna se enviara el tipo de pieza
       this.Pfila = fila;
       this.Pcolumna = columna;
       this.tablero[fila,columna]= tipo;

    }

    // Guardar la posicion de la reina

    public bool PosicionarDama(){
        bool respuesta = true;
        string dato = "";
       
// Filas
        for(int i=0; i<= 7; i++)
        {
            // verificar que la reina se pueda posicionar
            // mostrar los tipos de pieza por los que esta ocupada la posicion
            dato= tablero[this.Pcolumna,i];
            string colorpieza= dato.Substring(0,1);
            // condicion para verificar que la casilla sea diferente a vacio y que este ocupada por una pieza
            // mostrara las piezas por las que esta ocupada
             //Para validar  las posiciones vacias que no esten ocupadas y que no tengan el mismo color de la dama
            if(dato != "vacio"  && dato != "Dama" && colorpieza == this.colorDama)
            {
                // VALIDAR LA POSICION que no sea la reina
                    //Crear arreglo  para las columnas
                    string[] columnas = new string[8]{"A","B","C","D","E","F","G","H"};
                    this.piezas = "invalido";
                    Console.WriteLine(" | Posicion" + columnas[this.Pcolumna]+ ","+ Convert.ToInt16(i+1) + " = " + dato);
                    // Devolver respuesta falso, cada vez que el dato sea diferente a Reina
                    respuesta = false;
            }    

        }
// columnas

        for(int i=0; i<= 7; i++)
        {
            for(int j=0; j<= 7; j++)
            {
                dato= tablero[this.Pcolumna,i];
                //Extrae la letra n para definir el color
                string colorpieza= dato.Substring(0,1);

                if(dato != "vacio")
                { 
                    //Para validar  las posiciones vacias que no esten ocupadas y que no tengan el mismo color de la dama

                    if(dato != "vacio"  && dato != "Dama" && colorpieza == this.colorDama)
                    {
                        // VALIDAR LA POSICION que no sea la reina
                        //Crear arreglo  para las columnas
                        string[] columnas = new string[8]{"A","B","C","D","E","F","G","H"};
                        this.piezas = "invalido";
                        Console.WriteLine(" | Posicion" + columnas[this.Pcolumna]+ ","+ Convert.ToInt16(i+1) + " = " + dato);
                        respuesta = false;
                    }
            
                }

            }
        
        }
        
// diagonales derecha hacia arriba
    
        for(int i=7; i>0; i++)
        {

            for (int j=7; j>= 0; j++)
                {
                dato= tablero[i,j];
                //Extrae la letra n para definir el color
                string colorpieza= dato.Substring(0,1);

                Console.WriteLine(" " , tablero [i, j]);
                ///Para validar  las posiciones vacias que no esten ocupadas y que no tengan el mismo color de la dama
                if(dato != "vacio" && dato != "Dama" && colorpieza == this.colorDama)
                {
                    // VALIDAR LA posicion que no sea la reina
                    //Crear arreglo  para las columnas
                        string[] columnas = new string[8]{"A","B","C","D","E","F","G","H"};
                        this.piezas = "invalido";
                        Console.WriteLine(" | Posicion" + columnas[j]+ ","+ (i+1) + " = " + dato);
                        respuesta = false;
                }
                }
            
        }
          
// diagonales derecha hacia abajo
        for(int i=7; i>0; i--){

            for (int j=7; j>= 0; j++)
            {
                dato= tablero[i,j];
                //Extrae la letra n para definir el color
                string colorpieza= dato.Substring(0,1);

                Console.WriteLine(" " , tablero [i, j]);
                ///Para validar  las posiciones vacias que no esten ocupadas y que no tengan el mismo color de la dama
                if(dato != "vacio" && dato != "Dama" && colorpieza == this.colorDama)
                {
                    // VALIDAR LA posicion que no sea la reina
                    //Crear arreglo  para las columnas
                        string[] columnas = new string[8]{"A","B","C","D","E","F","G","H"};
                        this.piezas = "invalido";
                        Console.WriteLine(" | Posicion" + columnas[j]+ ","+ (i+1) + " = " + dato);
                        respuesta = false;
                }

            }
        }
// diagonales izquierda hacia arriba
        for(int k=7; k>0; k++){

            for (int j=7; j>= 0; j--)
             {
                dato= tablero[k,j];
                //Extrae la letra n para definir el color
                string colorpieza= dato.Substring(0,1);

                Console.WriteLine(" " , tablero [k, j]);
                ///Para validar  las posiciones vacias que no esten ocupadas y que no tengan el mismo color de la dama
                if(dato != "vacio" && dato != "Dama" && colorpieza == this.colorDama)
                {
                    // VALIDAR LA posicion que no sea la reina
                    //Crear arreglo  para las columnas
                        string[] columnas = new string[8]{"A","B","C","D","E","F","G","H"};
                        this.piezas = "invalido";
                        Console.WriteLine(" | Posicion" + columnas[j]+ ","+ (k+1) + " = " + dato);
                        respuesta = false;
                }

            }
// diagonales izquierda hacia abajo
        for(int l=7; l>0; l--){

            for (int j=0; j>= 7; j--)
            {
                dato= tablero[l,j];
                //Extrae la letra n para definir el color
                string colorpieza= dato.Substring(0,1);

                Console.WriteLine(" " , tablero [l, j]);
                ///Para validar  las posiciones vacias que no esten ocupadas y que no tengan el mismo color de la dama
                if(dato != "vacio" && dato != "Dama" && colorpieza == this.colorDama)
                {
                    // VALIDAR LA posicion que no sea la reina
                    //Crear arreglo  para las columnas
                        string[] columnas = new string[8]{"A","B","C","D","E","F","G","H"};
                        this.piezas = "invalido";
                        Console.WriteLine(" | Posicion" + columnas[j]+ ","+ (l+1) + " = " + dato);
                        respuesta = false;
                }
            }
        }
    }   
        return respuesta;
    }
}

    
    

