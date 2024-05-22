namespace Proyecto_2_pensamiento_computacional;

public class Pieza
{


// Funcionabilidad de la pieza
    public string Color;
    public string Tipopieza;
    public int Fila;
    public int Columna;

// Agregar una funcion para parametrizar la pieza 
    public Pieza(){

    }

    // Agregar constructor parametrizado
    public Pieza(string color, string Tipopieza)
    {
        
        this.Color = color;
        this.Tipopieza = Tipopieza;
    }


    
    // Crear metodo para guardar las posiciones ingresadas en la fila y la columna
    public void Posicionar(int Fila, string Columna)
    {
    
    int valorRealFila = Fila -1;
    int valorRealColumna = 0;

    //Convertir los valores reales
    switch (Columna.ToUpper())
    {
        case "A":
        valorRealColumna = 0;
        break;

        case "B":
        valorRealColumna = 1;
        break;

        case "C":
        valorRealColumna = 2;
        break;

        case "D":
        valorRealColumna = 3;
        break;

        case "E":
        valorRealColumna = 4;
        break;

        case "F":
        valorRealColumna = 5;
        break;

        case "G":
        valorRealColumna = 6;
        break;

        case "H":
        valorRealColumna = 7;
        break;
    
        default:
        Console.WriteLine("Columna no valida");
        break;

    }
    
    // Establecer la poscion exacta donde se guardaraN
    // LOS VALORES REALES DE LA FILA Y DE LA COLUMNA CON LOS ATRIBUTOS FILA Y COLUMNA
    
    this.Fila = valorRealFila;
    this.Columna = valorRealColumna;


    }


}
