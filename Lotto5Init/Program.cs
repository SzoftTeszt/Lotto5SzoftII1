using Lotto5Adat.Data;
using Lotto5Adat.Models;
LottoContext _context = new LottoContext();
if (!_context.LottoSzam.Any())
{

    string[] sorok = File.ReadAllLines(@"c:\Adat\adatok5.csv");
    foreach (var sor in sorok)
    {
        try
        {
            LottoSzam lottoSzam = new LottoSzam(sor);
            Console.WriteLine("Okés: " + lottoSzam);
            _context.LottoSzam.Add(lottoSzam);
        }
        catch
        {
            Console.WriteLine("Hibás"+sor);
        }
    }

    //_context.LottoSzam.Add(new LottoSzam("1;10;23;40;45"));
    _context.SaveChanges();
}
else {
    Console.WriteLine("Az adattábla már inicializált!");
}

