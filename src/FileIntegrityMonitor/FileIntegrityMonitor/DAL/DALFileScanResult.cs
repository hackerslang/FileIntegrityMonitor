using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileIntegrityMonitor.DTO;

namespace FileIntegrityMonitor.DAL
{
    public class DALFileScanResult : DALBase<FileScanResult>
    {
        public List<FileScanResult> GetScanResultsLatestComparedWithFirstPrevious(int hashAlgorithmId, int start, int number)
        {
            string query = @"
SELECT DISTINCT [fs].[FilePath],[fs].[FileSize],
(SELECT TOP 1 fs2.Checksum FROM FileScan fs2 WHERE fs.FilePath = fs2.FilePath ORDER BY [Time] DESC) AS LatestChecksum,
(SELECT fs3.Checksum FROM FileScan fs3 WHERE fs.FilePath = fs3.FilePath ORDER BY [TIME] DESC OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY) AS PreviousChecksum,
(SELECT TOP 1 fs2.Time FROM FileScan fs2 WHERE fs.FilePath = fs2.FilePath ORDER BY [Time] DESC) AS LatestTime,
(SELECT fs3.Time FROM FileScan fs3 WHERE fs.FilePath = fs3.FilePath ORDER BY [TIME] DESC OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY) AS PreviousTime

FROM FileScan fs ORDER BY FilePath OFFSET @Start ROWS
FETCH NEXT @Number ROWS ONLY";

            return this.SelectMultipleRecords(query,
                new Dictionary<string, object> { { "HashAlgorithmId", hashAlgorithmId },
                    { "@Start", start}, { "@Number", number } },
                this.GetScanResultFromReader);
        }

        public List<FileScanResult> GetScanResultCompare2Scans(Scan scanLatest, Scan scanPrevious, int start, int number)
        {
            string query = @"
SELECT DISTINCT
CASE
WHEN fs3.FilePath IS NOT NULL THEN fs3.FilePath
WHEN fs5.FilePath IS NOT NULL THEN fs5.Filepath
END AS FilePath,
[fs3].[FilePath] AS LatestFilePath,
[fs5].[FilePath] AS PreviousFilePath,
fs3.Checksum AS LatestChecksum, fs3.Time AS LatestTime, fs3.ErrorMessage AS LatestErrorMessage, 
fs5.Checksum AS PreviousChecksum, fs5.Time AS PreviousTime, fs5.ErrorMessage AS PreviousErrorMessage
FROM FileScan fs	
LEFT OUTER JOIN
(SELECT Checksum, Time, FilePath, FileScanError.ErrorMessage FROM FileScan  
LEFT OUTER JOIN FileScanError ON ErrorId = FileScanError.Id WHERE ScanId = @LatestScanId) fs3
ON fs.Filepath = fs3.FilePath
LEFT OUTER JOIN
(SELECT Checksum, Time, FilePath, FileScanError.ErrorMessage FROM FileScan
LEFT OUTER JOIN FileScanError ON ErrorId = FileScanError.Id WHERE ScanId = @PreviousScanId) fs5
ON fs.FilePath = fs5.FilePath
WHERE NOT (fs3.FilePath IS NULL AND fs5.FilePath IS NULL) ORDER BY (FilePath) OFFSET @Start ROWS
FETCH NEXT @Number ROWS ONLY";

            return this.SelectMultipleRecords(query,
                new Dictionary<string, object> {
                    { "@LatestScanId", scanLatest.Id },
                    { "@PreviousScanId", scanPrevious.Id },
                    {  "@Start", start},
                    { "@Number", number }
                },
                this.GetScanResultFromReader);
        }

        private FileScanResult GetScanResultFromReader(SqlDataReader reader)
        {
            return new FileScanResult
            {
                FilePath = Convert.ToString(reader["FilePath"]),

                LatestFileScan = new FileScan
                {
                    FilePath = Convert.ToString(reader["LatestFilePath"]),
                    Checksum = GetNullableStringFromReader(reader["LatestChecksum"]),
                    Time = GetNullableDateTimeFromReader(reader["LatestTime"]),
                    Error = new FileScanError
                    {
                        ErrorMessage = Convert.ToString(reader["LatestErrorMessage"])
                    }
                },

                PreviousFileScan = new FileScan
                {
                    FilePath = Convert.ToString(reader["PreviousFilePath"]),
                    Checksum = GetNullableStringFromReader(reader["PreviousChecksum"]),
                    Time = GetNullableDateTimeFromReader(reader["PreviousTime"]),
                    Error = new FileScanError
                    {
                        ErrorMessage = Convert.ToString(reader["PreviousErrorMessage"])
                    }
                }
            };
        }

        private string GetNullableStringFromReader(Object readerField)
        {
            return !Convert.IsDBNull(readerField) ? Convert.ToString(readerField) : null;
        }

        private DateTime? GetNullableDateTimeFromReader(Object readerField)
        {
            return !Convert.IsDBNull(readerField) ? Convert.ToDateTime(readerField) : (DateTime?)null;
        }
    }
}
