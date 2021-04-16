using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FileIntegrityMonitor.DTO;

namespace FileIntegrityMonitor.DAL
{
    class DALFileScan : DALBase<FileScan>
    {
        private const string _partialSelect = @"SELECT [Id], [FilePath], [Checksum], [FileSize], 
[Time], [ScanId] FROM [FileScan]";

        public List<FileScan> SelectAllFileScansFromScan(int scanId)
        {
            return this.SelectMultipleRecords(_partialSelect + " WHERE [ScanId] = @ScanId;", 
                new Dictionary<string, object>() { { "@ScanId", scanId } }, this.GetFileScanFromReader);
        }

        private FileScan GetFileScanFromReader(SqlDataReader reader)
        {
            return new FileScan
            {
                Id = Convert.ToInt32(reader["Id"]),
                FilePath = Convert.ToString(reader["FilePath"]),
                FileSize = Convert.ToInt64(reader["FileSize"]),
                Checksum = Convert.ToString(reader["Checksum"]),
                Time = Convert.ToDateTime(reader["Time"]),
                ScanId = Convert.ToInt32(reader["ScanId"])
            };
        }

        public bool InsertFileScan(FileScan fileScan)
        {
            return this.ExecQueryOneRecord(@"INSERT INTO [FileScan] ([FilePath], [Checksum], [FileSize], [Time], 
[ScanId]) VALUES(@FilePath, @checksum, @FileSize, @Time, @ScanId);", new Dictionary<string, object>()
            {
                { "@Filepath", fileScan.FilePath },
                { "@Checksum", fileScan.Checksum },
                { "@FileSize", fileScan.FileSize },
                { "@Time", fileScan.Time },
                { "@ScanId", fileScan.ScanId }
            });
        }

        public List<FileScan> GetAllLatestFileScans(int hashAlgorithmId)
        {
            string query = @"
SELECT [fs].[Id], [fs].[FilePath], [fs].[Checksum], [fs].[FileSize], [fs].[Time]
FROM [FileScan] fs INNER JOIN (
SELECT [Id], MAX([Time] AS LatestTime FROM [FileScan] GROUP BY [Id] HAVING [HashAlgorithmId] =
@hashAlgorithmId) AS fsMax 
ON [fs].[Time] = [fsMax].[LatestTime] AND [fs].[Id] = [fsMax].[Id]
";
            return this.SelectMultipleRecords(query,
                new Dictionary<string, object> { { "HashAlgorithmId", hashAlgorithmId } },
            this.GetFileScanFromReader);
        }

        public List<FileScan> GetAllLatestWithFirstPreviousFileScans(int hashAlgorithmId)
        {
            string query = @"
  SELECT [fs].[Id], [fs].[FilePath], [fs].[Checksum], [fs].[FileSize], [fs].[Time]
FROM FileScan fs WHERE fs.Id IN 
(SELECT TOP 2 fs2.Id FROM FileScan fs2 WHERE fs.FilePath = fs2.FilePath ORDER BY [Time] DESC)

 ORDER BY [fs].FilePath";
            return this.SelectMultipleRecords(query,
                new Dictionary<string, object> { { "HashAlgorithmId", hashAlgorithmId } },
            this.GetFileScanFromReader);
        }

        public List<FileScan> GetAllLatestWithFirstPreviousFileScansFromTo(int hashAlgorithmId, int start, int number)
        {
            string query = @"
SELECT DISTINCT [fs].[FilePath],[fs].[FileSize],
(SELECT TOP 1 fs2.Checksum FROM FileScan fs2 WHERE fs.FilePath = fs2.FilePath ORDER BY [Time] DESC) AS LatestChecksum,
(SELECT fs3.Checksum FROM FileScan fs3 WHERE fs.FilePath = fs3.FilePath ORDER BY [TIME] DESC OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY) AS PreviousChecksum,
(SELECT TOP 1 fs2.Time FROM FileScan fs2 WHERE fs.FilePath = fs2.FilePath ORDER BY [Time] DESC) AS LatestTime,
(SELECT fs3.Time FROM FileScan fs3 WHERE fs.FilePath = fs3.FilePath ORDER BY [TIME] DESC OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY) AS PreviousTime

FROM FileScan fs ORDER BY FilePath OFFSET 0 ROWS
FETCH NEXT 10 ROWS ONLY";

//            string query = @"
//SELECT [fs].[Id], [fs].[FilePath], [fs].[Checksum], [fs].[FileSize], [fs].[Time]
//FROM FileScan fs WHERE fs.Id IN 
//(SELECT TOP 2 fs2.Id FROM FileScan fs2 WHERE fs.FilePath = fs2.FilePath ORDER BY [Time] DESC)
//AND fs.FilePath IN (SELECT DISTINCT FilePath FROM FileScan ORDER BY FilePath OFFSET @Start ROWS
//FETCH NEXT @Number ROWS ONLY)";
            return this.SelectMultipleRecords(query,
                new Dictionary<string, object> { { "HashAlgorithmId", hashAlgorithmId },
                    { "@Start", start}, { "@Number", number } },
                this.GetFileScanFromReader);
        }

        public FileScan GetLatestFileScan(int hashAlgorithmId)
        {
            return this.SelectSingleRecord(@"SELECT TOP 1 [FileScan].[Id], [FilePath], [Checksum], [FileSize], 
[FileScan].[Time], [ScanId] FROM[ FileScan] [Scan].[HashAlgorithmId] = @HashAlgorithmId
ORDER BY [TIME] DESC;",
            new Dictionary<string, object> { { "HashAlgorithmId", hashAlgorithmId } },
            this.GetFileScanFromReader);
        }

        public FileScan GetLatestPreviousFileScan(DateTime latestTime, int hashAlgorithmId)
        {
            return this.SelectSingleRecord(@"SELECT TOP 1 [FileScan].[Id], [FilePath], [Checksum], [FileSize], 
[FileScan].[Time], [ScanId] FROM [FileScan] INNER JOIN [Scan] ON [FileScan].[ScanId] = [Scan].[Id] 
WHERE [FileScan].[Time] < @LatestTime AND [Scan].[HashAlgorithmId] = @HashAlgorithmId 
ORDER BY [TIME] DESC;",
            new Dictionary<string, object> { { "@LatestTime", latestTime },
                { "HashAlgorithmId", hashAlgorithmId } },
            this.GetFileScanFromReader);
        }
    }
}
