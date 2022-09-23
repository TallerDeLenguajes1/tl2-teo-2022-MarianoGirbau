public enum TipoDeExtraccion
{
    CajeroHumano=1,
    CajeroAutomatico=2
}
public class Cuenta
{
    protected float fondos;
    protected Cuenta()
    {
        fondos=0;
    }
    protected Cuenta(float x)
    {
        fondos = x;
    }
    public virtual void insercion(int monto)
    {
        fondos=fondos+monto;
    }
    public virtual void extraccion(int monto, TipoDeExtraccion tipo)
    {
        
    }
    public virtual float getFondos(){
        return fondos;
    }

}

public class CuentaCorrientePesos : Cuenta
{
    public override void extraccion(int monto, TipoDeExtraccion tipo)
    {
        if (fondos-monto>=-5000)
            {
                if (tipo==TipoDeExtraccion.CajeroAutomatico)
                {
                    if(monto>=20000){
                        fondos=fondos-monto;
                        Console.WriteLine("Extrajo $"+monto+" exitosamente.");
                        float fondoNuevo=getFondos();
                        Console.WriteLine("Sus fondos son: $"+fondoNuevo);
                    }else
                    {
                        Console.WriteLine("No puede extraer mas de $20000");
                    }
                }else if(tipo==TipoDeExtraccion.CajeroHumano)
                {
                    fondos=fondos-monto;
                    Console.WriteLine("Extrajo $"+monto+" exitosamente.");
                    float fondoNuevo=getFondos();
                    Console.WriteLine("Sus fondos son: $"+fondoNuevo);
                }
            }else
            {
                Console.WriteLine("No tiene fondos suficientes");
            }
    }
}
public class CuentaCorrienteDolares : Cuenta
{
    public override void extraccion(int monto, TipoDeExtraccion tipo)
    {
        if (fondos>=0)
            {
                if (tipo==TipoDeExtraccion.CajeroAutomatico)
                {
                    if(monto<=200){
                        fondos=fondos-monto;
                        Console.WriteLine("Extrajo $"+monto+" exitosamente.");
                        float fondoNuevo=getFondos();
                        Console.WriteLine("Sus fondos son: $"+fondoNuevo);
                    }else
                    {
                        Console.WriteLine("No puede extraer mas de U$D 200");
                    }
                }else if(tipo==TipoDeExtraccion.CajeroHumano)
                {
                    fondos=fondos-monto;
                    Console.WriteLine("Extrajo U$D"+monto+" exitosamente.");
                    float fondoNuevo=getFondos();
                    Console.WriteLine("Sus fondos son: U$D"+fondoNuevo);
                }
            }else
            {
                Console.WriteLine("No tiene fondos suficientes");
            }
    }
}

public class cajaAhorroPesos : Cuenta
{
    public override void extraccion(int monto, TipoDeExtraccion tipo)
    {
                if (fondos>=0)
            {
                if (tipo==TipoDeExtraccion.CajeroAutomatico)
                {
                    if(monto<=10000){
                        fondos=fondos-monto;
                        Console.WriteLine("Extrajo $"+monto+" exitosamente.");
                        float fondoNuevo=getFondos();
                        Console.WriteLine("Sus fondos son: $"+fondoNuevo);
                    }else
                    {
                        Console.WriteLine("No puede extraer mas de $10000");
                    }
                }else if(tipo==TipoDeExtraccion.CajeroHumano)
                {
                    fondos=fondos-monto;
                    Console.WriteLine("Extrajo $"+monto+" exitosamente.");
                    float fondoNuevo=getFondos();
                    Console.WriteLine("Sus fondos son: $"+fondoNuevo);
                }
            }else
            {
                Console.WriteLine("No tiene fondos suficientes");
            }
    }
}