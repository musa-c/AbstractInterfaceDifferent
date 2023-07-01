using System.Numerics;

namespace AbstractInterfaceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sqlDb = new SqlServerDb();
            sqlDb.ExecuteSql("");

            var oracleDb = new OracleDb();
            Console.WriteLine(oracleDb.GetDbVersion());
            oracleDb.ExecuteSql("");

            var car = new Car();
            car.Go();
            car.Stop();

            var plane = new Plane();
            plane.Go();
            plane.Stop();
            plane.Soar();

            var bike = new Bike();
            bike.Go();
            bike.Stop();
            bike.Ride();

            
            //IBaseDb x = new SqlServerDb();
            //x.ExecuteSql("");


            // bunun manası yok new'lenmesine gerek yok.
            // sadece görevi alt sınıflara hizmet ediyor. onun için abstract yapıyoruz.

            //var baseDb = new BaseDb();
            //baseDb.ExecuteSql("");
        }
    }
}