using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Server.Models
{
    public class CleanroomAAData
    {
        public string Org { get; set; }
        public DateTime DateTime { get; set; }
        public string ProductName { get; set; }
        public string SerialNumber { get; set; } = "1111111111";
        public string Status { get; set; }
        public string Station { get; set; }
        public string UserName { get; set; }
        public string JobNumber { get; set; }
        public string LotNumber { get; set; }
        public string TrayNumber { get; set; }
        public string FinalGrade { get; set; }
        public int Result { get; set; }
        public int FailCode { get; set; }
        public string MTFGrade { get; set; }
        public string CenteringGrade { get; set; }
        public string EFLGrade { get; set; }
        public string DOFGrade { get; set; }
        public string Class { get; set; }

        public double CheckFreq { get; set; }
        public double EFL { get; set; }
        public double FBL { get; set; }
        public double DecenterX { get; set; }
        public double DecenterY { get; set; }
        public double TiltAngle { get; set; }
        public double DOF_minus { get; set; }
        public double DOF_plus { get; set; }
        public double DOFT { get; set; }
        public double W_1S { get; set; }
        public double W_1T { get; set; }
        public double W_2S { get; set; }
        public double W_2T { get; set; }
        public double W_3S { get; set; }
        public double W_3T { get; set; }
        public double W_4S { get; set; }
        public double W_4T { get; set; }
        public double W_5S { get; set; }
        public double W_5T { get; set; }
        public double W_6S { get; set; }
        public double W_6T { get; set; }
        public double W_7S { get; set; }
        public double W_7T { get; set; }
        public double W_8S { get; set; }
        public double W_8T { get; set; }
        public double W_9S { get; set; }
        public double W_9T { get; set; }
        public double W_10S { get; set; }
        public double W_10T { get; set; }
        public double W_11S { get; set; }
        public double W_11T { get; set; }
        public double W_12S { get; set; }
        public double W_12T { get; set; }
        public double W_13S { get; set; }
        public double W_13T { get; set; }
        public double W_14S { get; set; }
        public double W_14T { get; set; }
        public double W_15S { get; set; }
        public double W_15T { get; set; }
        public double W_16S { get; set; }
        public double W_16T { get; set; }
        public double W_17S { get; set; }
        public double W_17T { get; set; }
        public double W1_Delta_S { get; set; }
        public double W1_Delta_T { get; set; }
        public double W1_Delta_percent_S { get; set; }
        public double W1_Delta_percent_T { get; set; }
        public double W2_Delta_S { get; set; }
        public double W2_Delta_T { get; set; }
        public double W2_Delta_percent_S { get; set; }
        public double W2_Delta_percent_T { get; set; }
        public double W3_Delta_S { get; set; }
        public double W3_Delta_T { get; set; }
        public double W3_Delta_percent_S { get; set; }
        public double W3_Delta_percent_T { get; set; }

        public int StainCount { get; set; }
        public int MaxStainSize { get; set; }
        public double StainRatio { get; set; }
        public string Mode { get; set; }
        public string GlueID { get; set; }
        public double GlueWeight { get; set; }
        public int IRcut { get; set; }

        public double Focus3_1S { get; set; }
        public double Focus3_1T { get; set; }
        public double Focus3_2S { get; set; }
        public double Focus3_2T { get; set; }
        public double Focus3_3S { get; set; }
        public double Focus3_3T { get; set; }
        public double Focus3_4S { get; set; }
        public double Focus3_4T { get; set; }
        public double Focus3_5S { get; set; }
        public double Focus3_5T { get; set; }
        public double Focus3_6S { get; set; }
        public double Focus3_6T { get; set; }
        public double Focus3_7S { get; set; }
        public double Focus3_7T { get; set; }
        public double Focus3_8S { get; set; }
        public double Focus3_8T { get; set; }
        public double Focus3_9S { get; set; }
        public double Focus3_9T { get; set; }
        public double Focus3_10S { get; set; }
        public double Focus3_10T { get; set; }
        public double Focus3_11S { get; set; }
        public double Focus3_11T { get; set; }
        public double Focus3_12S { get; set; }
        public double Focus3_12T { get; set; }
        public double Focus3_13S { get; set; }
        public double Focus3_13T { get; set; }
        public double Focus3_14S { get; set; }
        public double Focus3_14T { get; set; }
        public double Focus3_15S { get; set; }
        public double Focus3_15T { get; set; }
        public double Focus3_16S { get; set; }
        public double Focus3_16T { get; set; }
        public double Focus3_17S { get; set; }
        public double Focus3_17T { get; set; }
    }

}