int eleccion;
Boxeador boxeador1 = null;
Boxeador boxeador2 = null;

do
{
    eleccion = IngresarInt("I. Cargar Datos Boxeador 1\nII. Cargar Datos Boxeador 2\nIII. Pelear!\nIV. Salir");


    switch(eleccion){
        case (1):
            boxeador1 = crearBoxeador();
        break;
        case 2:
            boxeador2 = crearBoxeador();
        break;
        case 3:
            if (boxeador1 != null || boxeador2 != null)
        {   
            Console.WriteLine(boxeador1 + " " + boxeador2);
            pelear(boxeador1, boxeador2);
            Console.ReadKey();
            Console.Clear();
        } else  Console.WriteLine("Un boxeador no existe");
        break;
        default: 
            eleccion = 4;
        break;
    }


} while (eleccion != 4);

static int IngresarInt(string mensaje){
    Console.WriteLine(mensaje);
    return int.Parse(Console.ReadLine());
}

static string IngresarString(string mensaje){
    Console.WriteLine(mensaje);
    return Console.ReadLine();
}

static Boxeador crearBoxeador(){

    string nombre, pais;
    int peso, potencia, velocidad;


    do
    {
        nombre = IngresarString("Cual es el nombre?");
        pais = IngresarString("Cual es el pais?");
        peso = IngresarInt("Cual es el peso?");
        potencia = IngresarInt("Cual es la potencia?");
        velocidad = IngresarInt("Cual es la velocidad?");
    } while ((velocidad < 0 && velocidad > 100) || (potencia < 0 && potencia > 100));

        Boxeador boxeador = new Boxeador(nombre, pais, peso, potencia, velocidad);
        Console.WriteLine("Se ha creado el boxeador: " + nombre);
    return boxeador;
}

    static void pelear(Boxeador boxeador1, Boxeador boxeador2){

        if (boxeador1.ObtenerSKill() > boxeador2.ObtenerSKill())
        {
            if (boxeador1.ObtenerSKill() - boxeador2.ObtenerSKill() >= 30)
            {
                Console.WriteLine("Gano " + boxeador1.nombre + " por knockout");
            } else Console.WriteLine("Gano " + boxeador1.nombre + " por puntos en fallo dividido ");
            
        } else {
            if (boxeador2.ObtenerSKill() - boxeador1.ObtenerSKill() >= 30)
            {
                Console.WriteLine("Gano " + boxeador1.nombre + " por knockout");
            } else Console.WriteLine("Gano " + boxeador1.nombre + " por puntos en fallo dividido");
        }     
    }