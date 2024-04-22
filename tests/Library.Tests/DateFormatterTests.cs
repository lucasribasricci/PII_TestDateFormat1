using NUnit.Framework;
namespace Library.Tests;
namespace TestDateFormat

    [TestFixture]

    {
    public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Fecha_Valida()
    {
        string fecha_correcta = "26/11/2004";
        const string expected = "26-11-2004";
        string datetest = DateFormatter.ChangeFormat(fecha_correcta);
        Assert.AreEqual(datetest, expected);
    }
    [Test]
    public void Fecha_Invalida()
    {
        string fecha_incorrecta = "000/11/2004";
        const string expected = "";
        string datetest = DateFormatter.ChangeFormat(fecha_incorrecta);
        Assert.AreEqual(datetest, expected);

    }
    [Test]
    public void Fecha_Vacia()
    {
        string fecha_empty = "";
        const string expected = "";
        string datetest = DateFormatter.ChangeFormat(fecha_empty);
        Assert.AreEqual(datetest, expected);
    }
}
}
