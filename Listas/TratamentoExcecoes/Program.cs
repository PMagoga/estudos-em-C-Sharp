
try
{
	Console.WriteLine("\nInforme o dividendo");
	int dividendo = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("\nInforme o divisor");
	int divisor = Convert.ToInt32(Console.ReadLine());
	int resultado = (dividendo / divisor);
	Console.WriteLine($"\n{dividendo}/{divisor} = {resultado}\n");
	Console.ReadKey();

}
catch (DivideByZeroException) when (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
{

	Console.WriteLine("\nHoje é sexta-feira e não capturamos estas exceções por motivos óbvios.. \n\nSextouuu\n");
}
catch(Exception ex) when (ex.Message.Contains("format"))
{
	Console.WriteLine("filtro de exceção com format");
	Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
	Console.WriteLine(ex.Message);
	Console.WriteLine(ex.StackTrace);
}

Console.ReadKey();