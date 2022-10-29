using System;

class ElevatorWell
{
    private bool subir {set; get;}
    private bool bajar {set; get;}
    private int usuario {set; get;}
    private bool encendido {set; get;}
    private bool apagado {set; get;}
    private int piso {set; get;}
    private bool abiertas {set; get;}
    private bool cerradas {set; get;}
    private bool puertas {set; get;}



    public ElevatorWell()
    {
        Console.WriteLine("El elevador no esta en uso. \n");
        apagado = true;
        piso = 1;
        cerradas = true;
        usuario = 0;
    }

    //Usuario en el elevador

    public void setUsuario(int usuario)
    {
        this.usuario = usuario;
    }

    public int getUsuario()
    {
        return this.usuario;
    }

    //Encendiendo el elevador
    public void setEncender(bool encender)
    {
        this.encendido = encender;
    }

    public bool getEncender()
    {
        return this.encendido;
    }

    //EApagando el elevador
    public void setApagar(bool apagar)
    {
        this.apagado = apagar;
    }

    public bool getApagar()
    {
        return this.apagado;
    }

    //Piso en cual se encuentra el elevador
    public void setPiso(int piso)
    {
        for(int p = 1; p<=piso; p++)
        {
            Console.WriteLine("Usted va por el piso " + p + "\n");
        
        }
        this.piso = piso;
    }

    public int getPiso()
    {
        return piso;
    }

    //Puertas abiertas
    public void setAbrir(bool puertas)
    {
        this.puertas = puertas;
        Console.WriteLine("Bienvenido a ElevaTorwell");
    }

    public bool getAbrir()
    {
        return this.puertas;
    }

    //Puertas cerradas
    public void setCerrar(bool puertas)
    {
        this.puertas = puertas;
    }

    public bool getCerrar()
    {
        return this.puertas;
    }

    //Subir de piso
    public void setSubir(bool subir)
    {
        this.subir = subir;
    }

    public bool getSubir()
    {
        return this.subir;
    }

    //Bajar de piso
    public void setBajar(bool bajar)
    {
        this.bajar = bajar;
    }

    public bool getBajar()
    {
        return this.bajar;
    }
    
    //Estado del elevador
    public void EstadoElevador()
    {
        Console.WriteLine("El elevador se encuentra en el siguiente estado.\n");
        Console.WriteLine("Puertas cerradas:    {0}\n", getCerrar());
        Console.WriteLine("El elevador esta apagado:    {0}\n", getApagar());
        Console.WriteLine("El elevador se encuentra en el piso:     {0}\n", getPiso());
    }


}

//Tester-Class

class Program
{
    public static void Main()
    {
        ElevatorWell miElevador = new ElevatorWell();

        Console.WriteLine("***Estado actual del elevador.***\n");
        // miElevador.EstadoElevador();

        //Encender elevador
        miElevador.setEncender(true);
        miElevador.getEncender();

        //Abrir puertas del elevador
        miElevador.setAbrir(true);
        miElevador.getAbrir();

        //Cerrar puertas del elevador
        miElevador.setCerrar(true);
        miElevador.getCerrar();

        //Cantidad de Usuarios en el elevador
        miElevador.setUsuario(3);
        miElevador.getUsuario();
        
        //Pisos totales del elevador
        miElevador.setPiso(4);
        miElevador.getPiso();

        //El elevador esta subiendo
        miElevador.setSubir(true);
        miElevador.getSubir();

        //El elevador esta bajando
        miElevador.setBajar(true);
        miElevador.getBajar();

        //El elevador esta apagado
        miElevador.setApagar(true);

        Console.WriteLine("Abrir puertas:   {0}", miElevador.getAbrir());
        Console.WriteLine("Encender elevador:   {0}", miElevador.getEncender());
        Console.WriteLine("Cantidad de usuarios:    {0}", miElevador.getUsuario());
        Console.WriteLine("Cerrar puertas del elevador:    {0}", miElevador.getCerrar());
        Console.WriteLine("Subir elevador al piso indicado:     {0}", miElevador.getSubir());
        Console.WriteLine("Ha llegado a su destino");
        Console.WriteLine("Cantidad de pisos a subir:   {0}", miElevador.getPiso());


    }
}