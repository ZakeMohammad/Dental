using HudaClinc_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HudaClinc_BusinessLayer
{
    public class clsAppointments
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int StartTimeMuinets { get; set; }
        public int StartTimeHours { get; set; }
        public int EndTImeMuinets { get; set; }
        public int EndTimeHours { get; set; }
        public DateTime Date { get; set; }
        public int DoctorID { get; set; }
        public string Notes { get; set; }
        public int? Status { get; set; }

        public clsPatients Patients { get;  }
        public clsDoctors Doctors { get; }
        public string AMOrPM {  get; set; }

      public clsAppointments()
    {
        Mode = enMode.Add;
        this.AppointmentID = 0;
        this.PatientID = 0;
        this.StartTimeMuinets = 0;
        this.StartTimeHours = 0;
        this.EndTImeMuinets = 0;
        this.EndTimeHours = 0;
        this.Date = DateTime.Now;
            this.DoctorID = 0;
        this.Notes = null;
        this.Status = null;
            this.AMOrPM = null ;
    }

      private clsAppointments(int AppointmentID, int PatientID, int StartTimeMuinets, int StartTimeHours, int EndTImeMuinets, int EndTimeHours,DateTime Date, int DoctorID, string Notes, int? Status,string AMOrPM)
    {
        Mode = enMode.Update;
        this.AppointmentID = AppointmentID;
        this.PatientID = PatientID;
        this.StartTimeMuinets = StartTimeMuinets;
        this.StartTimeHours = StartTimeHours;
        this.EndTImeMuinets = EndTImeMuinets;
        this.EndTimeHours = EndTimeHours;
        this.Date = Date;
        this.DoctorID = DoctorID;
        this.Notes = Notes;
        this.Status = Status;
        this.AMOrPM = AMOrPM;

            this.Doctors = clsDoctors.Find(DoctorID);
            this.Patients = clsPatients.Find(PatientID);
    }


      private bool _AddNew()
    {
        this.AppointmentID = clsAppointmentsData.AddNewAppointments(this.PatientID, this.StartTimeMuinets, this.StartTimeHours, this.EndTImeMuinets, this.EndTimeHours, this.Date, this.DoctorID, this.Notes, this.Status,this.AMOrPM);

        return (this.AppointmentID != 0);
    }


      private bool _Update()
    {
        return clsAppointmentsData.UpdateAppointments(this.AppointmentID, this.PatientID, this.StartTimeMuinets, this.StartTimeHours, this.EndTImeMuinets, this.EndTimeHours, this.Date, this.DoctorID, this.Notes, this.Status,this.AMOrPM);
    }


      public static clsAppointments Find(int AppointmentID)
    {
        int PatientID = 0;
        int StartTimeMuinets = 0;
        int StartTimeHours = 0;
        int EndTImeMuinets = 0;
        int EndTimeHours = 0;
        DateTime Date = DateTime.Now;
        int DoctorID = 0;
        string Notes = null;
        int? Status = null;
            string AMOrPM = null;

        if (clsAppointmentsData.FindAppointments(ref AppointmentID, ref PatientID, ref StartTimeMuinets, ref StartTimeHours, ref EndTImeMuinets, ref EndTimeHours, ref Date, ref DoctorID, ref Notes, ref Status,ref AMOrPM))
            return new clsAppointments(AppointmentID, PatientID, StartTimeMuinets, StartTimeHours, EndTImeMuinets, EndTimeHours, Date, DoctorID, Notes, Status, AMOrPM);
        else
            return null;
    }



        public static clsAppointments FindForPatiantDetelis(int PatientID)
        {
            int AppointmentID = 0;
            int StartTimeMuinets = 0;
            int StartTimeHours = 0;
            int EndTImeMuinets = 0;
            int EndTimeHours = 0;
            DateTime Date = DateTime.Now;
            int DoctorID = 0;
            string Notes = null;
            int? Status = null;
            string AMOrPM = null;

            if (clsAppointmentsData.FindForPatiantDetelis(ref AppointmentID,  PatientID, ref StartTimeMuinets, ref StartTimeHours, ref EndTImeMuinets, ref EndTimeHours, ref Date, ref DoctorID, ref Notes, ref Status,ref AMOrPM))
                return new clsAppointments(AppointmentID, PatientID, StartTimeMuinets, StartTimeHours, EndTImeMuinets, EndTimeHours, Date, DoctorID, Notes, Status, AMOrPM);
            else
                return null;
        }

        public bool Save()
    {
        switch (Mode)
        {

            case enMode.Add:
                {
                    if (_AddNew())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                }
            case enMode.Update:
                {
                    return _Update();
                }
            defult:
                return false;
        }
        return false;
    }


      public static bool Delete(int AppointmentID)
    {
        return clsAppointmentsData.DeleteAppointments(AppointmentID);
    }


      public static bool IsAppointmentsExist(int AppointmentID)
    {
        return clsAppointmentsData.IsAppointmentsExist(AppointmentID);
    }


      public static DataTable All()
      {
        return clsAppointmentsData.AllAppointments();
      }

        public static DataTable All(string Date)
        {
            return clsAppointmentsData.AllAppointments(Date);
        }

        public bool CheakValidety()
        {
            return clsAppointmentsData.IsThereAnyAppointmentinThiTimeAndDate(this.StartTimeHours, this.StartTimeMuinets, this.EndTimeHours, this.EndTImeMuinets, this.AMOrPM, this.Date);
        }


        static bool PeriodsIntersect(int startAdmin, int endAdmin, int startSystem, int endSystem)
        {
            if (startAdmin <= endSystem && startSystem <= endAdmin)
                return true;
            else
                return false;
        }

        public bool IsThereOverlappingTime(int StartTimeHourFormAdmin, int EndTimeHourFormAdmin, string DateAdmin,string pm)
        {
            int NumberofOverlapping = 0;
            DataTable TabelForAllTimes = clsAppointmentsData.AllAppointmentsStartTimeAndEndTIme(DateAdmin,pm);

            foreach (DataRow Row in TabelForAllTimes.Rows)
            {
                if(PeriodsIntersect(StartTimeHourFormAdmin, EndTimeHourFormAdmin, Convert.ToInt32(Row["StartTimeHours"]), Convert.ToInt32(Row["EndTimeHours"])))
                {
                    NumberofOverlapping = 11;
                    break;
                }
            }

            return NumberofOverlapping >0;
        }

     
        public static Dictionary<int,int> AllIntervalInTthisDay(string date,string pm)
        {
            return clsAppointmentsData.AllIntervalInTthisDay(date,pm);
        }

        public static  bool ChangeStatus(int ap,int status)
        {
            return clsAppointmentsData.ChangeStatus(ap, status);
        }
    }
}
