using FileIntegrityMonitor.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIntegrityMonitor.DTO
{
    public enum FileScanStatus
    {
        NewFile,
        UnchangedFile,
        ChangedFile,
        FileRemoved,
        FileError,
        UnknownError
    }
    public class FileScanResult
    {
        public string FilePath { get; set; }
        public FileScan LatestFileScan { get; set; }
        public FileScan PreviousFileScan { get;set; }

        public FileScanStatus Status
        {
            get
            {
                FileScanStatus status;

                if (LatestFileScan.FilePath == null && PreviousFileScan.FilePath != null)
                {
                    status = FileScanStatus.FileRemoved;
                }
                else if (PreviousFileScan.FilePath == null && LatestFileScan.FilePath != null)
                {
                    status = FileScanStatus.NewFile;
                }
                else if (!string.IsNullOrEmpty(LatestFileScan.Error.ErrorMessage) || !string.IsNullOrEmpty(PreviousFileScan.Error.ErrorMessage))
                {
                    status = FileScanStatus.FileError;
                }
                else
                {
                    if (LatestFileScan.Checksum == PreviousFileScan.Checksum)
                    {
                        status = FileScanStatus.UnchangedFile;
                    }
                    else if (LatestFileScan.Checksum != PreviousFileScan.Checksum)
                    {
                        status = FileScanStatus.ChangedFile;
                    }
                    else
                    {
                        status = FileScanStatus.UnknownError;
                    }
                }

                return status;
            }
        }

        public string StatusString
        {
            get
            {
                String text;

                switch (this.Status)
                {
                    case FileScanStatus.ChangedFile:
                        text = "Changed file";
                        break;
                    case FileScanStatus.UnchangedFile:
                        text = "Unchanged file";
                        break;
                    case FileScanStatus.NewFile:
                        text = "New file";
                        break;
                    case FileScanStatus.FileRemoved:
                        text = "File removed";
                        break;
                    default: //Error
                        text = "Error";
                        break;
                }

                return text;
            }
        }

        public static List<FileScanResult> GetScanResultCompare2Scans(Scan latestScan, Scan previousScan, int start, int number)
        {
            return new DALFileScanResult().GetScanResultCompare2Scans(latestScan, previousScan, start, number);
        }
    }
}
