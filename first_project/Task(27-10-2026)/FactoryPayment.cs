using System;

public interface IPayment
{
    void payment(int amount);
}

public class Cash : IPayment
{
    public void payment(int amount) => Console.WriteLine($"{amount} is payed through cash");
}

public class GPay : IPayment
{
    public void payment(int amount) => Console.WriteLine($"{amount} is credited through GPay");
}

public class CreditCard : IPayment
{
    public void payment(int amount) => Console.WriteLine($"{amount} is credited with CreditCard");
}

public class PaymentFactory
{
    public static IPayment PaymentMethod(String paymentMethod)
    {
        if(paymentMethod == "Cash")
        {
            return new Cash();
        }
        else if(paymentMethod == "GPay")
        {
            return new GPay();
        }
        else if(paymentMethod == "CreditCard")
        {
            return new CreditCard();
        }
        else
        {
            return null;
        }
    }
}

class ExecFactPayment
{
    static void Main(string[] args)
    {
        IPayment paymeth1 = PaymentFactory.PaymentMethod("Cash");
        paymeth1.payment(10000);

        IPayment paymeth2 = PaymentFactory.PaymentMethod("GPay");
        paymeth2.payment(15000);

        IPayment paymeth3 = PaymentFactory.PaymentMethod("CreditCard");
        paymeth3.payment(20000);
    }
}