using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceProject
{
    // birden fazla class'ın içinde aynı işlemleri yapan metotlar varsa
    // bunları base class içine alabiliriz. bu şekilde tek bir yere toplamış oluruz.

    // tek bir yere toplamak yetmiyor bu class'ın kullanım amacı sadece 
    // DataBase'lere hizmet ediyor.Yani baseDb'yi new'leyip birşey yapmıyoruz.
    // bu yüzden bu class'ı abstract yapmalıyız(new'lenmemesini sağlıyoruz.).

    // abstract temel amaçları 1. ortaklaştırmak 2. soyutlamak'dır.

    // Peki şöyle bir şey'de var bazı class'larda aynı imzadan metotlar var 
    // ama body kısımları farklı. abstract classın içinde abstract metot tanımlarım 
    // interface'dekiler gibi tanımlama yapabilirim böylelikle.
    // alt sınıfta metodu override etmek koşuluyla.

    // dolayısıyla abstract'ı hem bir ortak imza gibi
    // hemde ortak metot body'leri için kullanabiliriz. 

    // interface'i böyle de tanımlayabiliriz c# 8.0'dan sonra

    /*
  public interface IBaseDb
  {
      public string GetDbVersion();
      public DataTable ExecuteSql(string sql)
      {
          // generate sql
          return new DataTable();
      }
  }
  */

    // fakat implemente edilen class üzerinden ulaşamayız ExecuteSql'e
    // BaseDb referansı üzerinden oluşabiliriz örneğin:

    //IBaseDb sqlDb = new SqlServerDb();
    //sqlDb.ExecuteSql("");

    // c# 8.0'dan önce interface içinde default implement yapamazdık.
    // ondan dolayı abstract kullanıyoruz.

    // bir class'a birden fazla interface'den miras alabiliriz.
    // ama bir class sadece bir abstract class'tan miras alabilir.
    public abstract class BaseDb
    {
        public abstract string GetDbVersion();
        public DataTable ExecuteSql(string sql)
        {
            // generate sql
            return new DataTable();
        }
    }

    public class MySqlDb : BaseDb
    {
        public override string GetDbVersion() => "MySql Database";
    }

    public class SqlServerDb : BaseDb
    {
        public override string GetDbVersion() => "SQL Server Connection";
        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WITH(NOLOCK) WHERE ID = {id}";
        }
    }

    class OracleDb : BaseDb
    {
         public override string GetDbVersion() => "Oracle 18c";
         public string GenerateSql(int id)
         {
             return $"SELECT * FROM USERS WHERE ID = {id}";
         }
    }
}
