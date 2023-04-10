class Boxeador{

    public Boxeador(string nombre, string pais, int peso, int potencia, int velocidad){
        this.nombre = nombre;
        this.pais = pais;
        this.peso = peso;
        this.potencia = potencia;
        this.velocidad = velocidad;

    }

    public string nombre {get; private set;}
    public string pais {get; private set;}
    public int peso {get; private set;}
    public int potencia {get; private set;}
    public int velocidad {get; private set;}

    public int ObtenerSKill(){

        Random num = new Random();
        double skill = (velocidad * 0.6) + (potencia * .8) + num.Next(1, 11);


        return Convert.ToInt32(skill);
    }
}