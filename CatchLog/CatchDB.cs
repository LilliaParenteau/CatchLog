using Microsoft.Data.SqlClient;
using System.Data;

namespace CatchLog
{
    public static class CatchDB
    {
        private const string ConnectionString =
            @"Server=(localdb)\MSSQLLocalDB;Database=CatchLogDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public static DataTable GetCatches(string searchText = "")
        {
            string query = @"
                  SELECT CatchDate, Species, Location, Bait,
                         LengthInches, WeightPounds, CatchID
                  FROM dbo.catches
                  WHERE @SearchText = ''
                    OR CHARINDEX(@SearchText, Species) > 0
                    OR CHARINDEX(@SearchText, Location) > 0
                  ORDER BY CatchDate DESC, CatchId DESC;";

            using SqlConnection connection = new SqlConnection(ConnectionString);
            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@SearchText", SqlDbType.NVarChar, 150)
                .Value = searchText.Trim();

            using SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable catches = new DataTable();

            connection.Open();
            adapter.Fill(catches);

            return catches;
        }

        public static void AddCatch(
            DateTime catchDate,
            string species,
            string location,
            string bait,
            decimal length,
            decimal weight)
        {
            string query =
                @"INSERT INTO dbo.catches
                    (CatchDate, Species, Location, Bait,
                     LengthInches, WeightPounds)
                  VALUES
                    (@CatchDate, @Species, @Location, @Bait,
                     @Length, @Weight);";

            using SqlConnection connection = new SqlConnection(ConnectionString);
            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@CatchDate", SqlDbType.Date).Value =
                catchDate.Date;

            command.Parameters.Add("@Species", SqlDbType.NVarChar, 100).Value =
                species;

            command.Parameters.Add("@Location", SqlDbType.NVarChar, 150).Value =
                location;

            command.Parameters.Add("@Bait", SqlDbType.NVarChar, 100).Value =
                string.IsNullOrWhiteSpace(bait) ? DBNull.Value : bait;

            SqlParameter lengthParameter =
                command.Parameters.Add("@Length", SqlDbType.Decimal);
            lengthParameter.Precision = 8;
            lengthParameter.Scale = 2;
            lengthParameter.Value = length;

            SqlParameter weightParameter =
                command.Parameters.Add("@Weight", SqlDbType.Decimal);
            weightParameter.Precision = 8;
            weightParameter.Scale = 2;
            weightParameter.Value = weight;

            connection.Open();
            command.ExecuteNonQuery();
        }

        public static void DeleteCatch(int CatchID)
        {
            string query = "DELETE FROM dbo.Catches WHERE CatchID = @CatchID;";

            using SqlConnection connection =
                new SqlConnection(ConnectionString);

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.Add("@CatchID", SqlDbType.Int)
                .Value = CatchID;

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}