using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OCDataImporter
{

    public enum StatusAfterUpload
    { 
        MARKED_COMPLETE,
        DATA_ENTRY_STARTED
    }

    public enum InitialStatusCRFS
    {
        NO_DATA_ENTERY_STARTED,
        DATA_ENTERY_STARTED
    }
    
    class ConversionSettings
    {
        public String dateFormat { get; set; }
        public String defaultLocation { get; set; }
        public String selectedCRF { get; set; }
        public String selectedStudyEvent{ get; set; }
        public String selectedEventRepeating { get; set; }
        public String studyOID { get; set; }
        public String workdir { get; set; }        
        public String pathToInputFile { get; set; }
        public String SUBJECTSEX_F { get; set; }
        public String SUBJECTSEX_M { get; set; }
        public String defaultSubjectSex { get; set; }
        public String pathToMetaDataFile { get; set; } 

        public bool useTodaysDateIfNoEventDate { get; set; }
        public bool checkForDuplicateSubjects { get; set; }
        public bool useStatusAfterUpload { get; set; }
       
        public bool uploadOnNotStarted { get; set; }
        public bool uploadOnDataEntryStarted { get; set; }
        public bool uploadOnDataEntryComplete { get; set; }

        public int sepCount { get; set; }
        public int outFMaxLines { get; set; }
        public StatusAfterUpload statusAfterUpload { get; set; }
        public InitialStatusCRFS initialStatusCRFs { get; set; }

        public ArrayList Groups { get; set; }
        public ArrayList Forms { get; set; }
        public ArrayList Sites { get; set; }
        public bool DOY { get; set; }

        public void reset() {
            workdir = "";
            pathToMetaDataFile = "";
            pathToInputFile = "";
            checkForDuplicateSubjects = false;
            useStatusAfterUpload = false;            
        }

        public Boolean isUpsertOnRequested()
        {
            return uploadOnNotStarted | uploadOnDataEntryComplete | uploadOnDataEntryStarted;
        }

        
    }
}
