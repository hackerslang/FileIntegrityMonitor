using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileIntegrityMonitor.DTO;
using System.Data;
using System.Data.SqlClient;

namespace FileIntegrityMonitor.DAL
{
    public class DALScan : DALBase<Scan>
    {
        private const string _partialSelect = @"SELECT [Scan].[ID], [Title], [FilePath], [HashAlgorithmId], [HashAlgorithms].[Name]
            As HashAlgorithmName, [Time] FROM[Scan] INNER JOIN[HashAlgorithms] 
            ON [Scan].[HashAlgorithmId] = [HashAlgorithms].[Id]";

        public List<Scan> SelectAllScans()
        {
            return this.SelectMultipleRecords(_partialSelect + " ORDER BY [Time] DESC", 
                new Dictionary<string, object>() { }, this.GetScanFromReader);
        }

        public Scan SelectScan(int id)
        {
            return this.SelectSingleRecord(_partialSelect + " WHERE [Scan].[ID] = @Id  ORDER BY [Time] DESC;", 
                new Dictionary<string, object>() { { "@Id", id } }, this.GetScanFromReader);
        }

        private Scan GetScanFromReader(SqlDataReader reader)
        {
            return new Scan
            {
                Id = Convert.ToInt32(reader["ID"]),
                Title = Convert.ToString(reader["Title"]),
                FilePath = Convert.ToString(reader["FilePath"]),
                HashAlgorithm = new FIMHashAlgorithm {
                    Id = Convert.ToInt32(reader["HashAlgorithmId"])
                },
                Time = Convert.ToDateTime(reader["Time"])
            };
        }

        public int InsertScan(Scan scan)
        {
            return this.ExecQueryGetScalar(@"INSERT INTO [Scan] ([FilePath], [HashAlgorithmId], [Time])
 VALUES(@FilePath, @HashAlgorithmId, @Time); SELECT SCOPE_IDENTITY() AS INT;", new Dictionary<string, object>()
            {
                { "@Filepath", scan.FilePath },
                { "@HashAlgorithmId", scan.HashAlgorithm.Id },
                { "@Time", scan.Time }
            });
        }

        public bool DeleteScan(Scan scan)
        {
            return this.ExecQueryOneRecord(@"DELETE FROM [Scan] WHERE [Id] = @Id;",
                new Dictionary<string, object>() { { "@Id", scan.Id } });
        }

        public int CountFilePaths2Scans(Scan scan1, Scan scan2)
        {
            return this.ExecQueryGetScalar(@"
SELECT COUNT(DISTINCT FilePath) FROM FileScan WHERE ScanId = @Scan1Id OR ScanId = Scan2Id",
                new Dictionary<string, object>()
                {
                    { "@Scan1Id", scan1.Id },
                    { "@Scan2Id", scan2.Id }
                });
        }
    }
}
