public class Cuenta {

    float fondo;
    TipoDeCuenta TipoCuenta;
    public enum TipoDeCuenta
    {
        CuentaCorrientePesos=1,
        CuentaCorrienteDolares=2,
        CajaAhorroPesos=3,
    }

    public enum TipoDeExtraccion
    {
        CajeroHumano=1,
        CajeroAutomatico=2
    }

    public void Insercion (int monto){
       fondo = fondo+monto;
    }

    public void Extraccion (int monto, TipoDeExtraccion tipo){
        if (TipoCuenta==TipoDeCuenta.CuentaCorrientePesos)
        {
            if (fondo-monto>=-5000)
            {
                if (tipo==TipoDeExtraccion.CajeroAutomatico)
                {
                    if(monto>=20000){
                        fondo=fondo-monto;
                    }else
                    {
                        Console.WriteLine("No puede extraer mas de $20000");
                    }
                }else if(tipo==TipoDeExtraccion.CajeroHumano)
                {
                    fondo=fondo-monto;
                }
            }else
            {
                Console.WriteLine("No tiene fondos suficientes");
            }
        }
        else if(TipoCuenta==TipoDeCuenta.CuentaCorrienteDolares)
        {

        }
        else if(TipoCuenta==TipoDeCuenta.CajaAhorroPesos)
        {

        }
    }
}