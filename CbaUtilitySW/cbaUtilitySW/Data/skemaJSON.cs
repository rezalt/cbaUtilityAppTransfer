using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace cbaUtility.Data
{
    class skemaJSON
    {
        public static string skema = @"{
	""columnheaders"": [""Hold"", ""Lokale"", ""Underviser"", ""Fag"", ""Beskrivelse"", ""Emne"", ""Læringsmål"", ""Ressourcer"", ""Tilstedeværelse"", ""Studentaktivitet"", ""Kommentar"", ""Link"", ""Eksterne kontakter"", ""Kategori""],
	""info"": {
		""reservationlimit"": 200,
		""reservationcount"": 200
	},
	""reservations"": [{
		""id"": ""69386"",
		""startdate"": ""2017-10-30"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-10-30"",
		""endtime"": ""12:00"",
		""columns"": [""l17dat4io1e"", ""CL-101"", ""aka, tog"", ""IoT ((Internet of Things)"", """", """"]
	}, {
		""id"": ""69917"",
		""startdate"": ""2017-10-30"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-10-30"",
		""endtime"": ""12:00"",
		""columns"": [""l17dat3ae"", ""CL-103"", ""tha"", ""Modul 3"", """", """"]
	}, {
		""id"": ""70814"",
		""startdate"": ""2017-10-30"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-10-30"",
		""endtime"": ""12:00"",
		""columns"": [""l17wed1ve"", ""CL-266 D"", ""moro"", """", """", """"]
	}, {
		""id"": ""71389"",
		""startdate"": ""2017-10-30"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-10-30"",
		""endtime"": ""12:00"",
		""columns"": [""l17sou1ae, l17sou2ae"", ""CL-203"", ""koe"", ""Udforskning & formidling"", """", """"]
	}, {
		""id"": ""73689"",
		""startdate"": ""2017-10-30"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-10-30"",
		""endtime"": ""12:00"",
		""columns"": [""l17ine1ue, l17ino1be"", ""CL-164/66D"", ""pbj, runa"", ""Investor Pitch"", """", ""This day is a further extended and in-depth workout session of the training from Pitch Workshop 1, the feedback from this workshop, the reflections from the masterclass with Bill Aulet and the task given from Workshop 1: Focus on the investor part and in""]
	}, {
		""id"": ""73945"",
		""startdate"": ""2017-10-30"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-10-30"",
		""endtime"": ""12:00"",
		""columns"": [""l17spm1ue, l17spo1ae"", ""CL-312 Open learning"", ""bonn, crsc"", ""Marketing"", """", ""Pitch presentations - panel discussion & P2P feedback.""]
	}, {
		""id"": ""74257"",
		""startdate"": ""2017-10-30"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-10-30"",
		""endtime"": ""12:00"",
		""columns"": [""l17fic3ae"", ""CL-364 D"", ""amha"", ""Controlling og revision"", """", """"]
	}, {
		""id"": ""78293"",
		""startdate"": ""2017-10-30"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-10-30"",
		""endtime"": ""12:00"",
		""columns"": [""l17mak3rm1e"", ""CL-305"", ""carb, jch"", """", """", ""Guest speaker: Jan Borg""]
	}, {
		""id"": ""69333"",
		""startdate"": ""2017-10-30"",
		""starttime"": ""12:30"",
		""enddate"": ""2017-10-30"",
		""endtime"": ""16:00"",
		""columns"": [""l17dat1ce"", ""CL-262"", ""roda"", ""Modul 3"", """", """"]
	}, {
		""id"": ""70151"",
		""startdate"": ""2017-10-30"",
		""starttime"": ""12:30"",
		""enddate"": ""2017-10-30"",
		""endtime"": ""16:00"",
		""columns"": [""l17dat2ae"", ""CL-105"", ""koe, tha"", ""Modul 4"", """", """"]
	}, {
		""id"": ""70916"",
		""startdate"": ""2017-10-30"",
		""starttime"": ""12:30"",
		""enddate"": ""2017-10-30"",
		""endtime"": ""16:00"",
		""columns"": [""l17mul1ae"", ""CL-266 D"", ""fdta"", ""Vejledning"", ""Projekt"", """"]
	}, {
		""id"": ""71382"",
		""startdate"": ""2017-10-30"",
		""starttime"": ""12:30"",
		""enddate"": ""2017-10-30"",
		""endtime"": ""16:00"",
		""columns"": [""l17sod2ue"", ""CL-203"", ""rhp"", ""Udforskning & formidling"", """", """"]
	}, {
		""id"": ""72289"",
		""startdate"": ""2017-10-30"",
		""starttime"": ""12:30"",
		""enddate"": ""2017-10-30"",
		""endtime"": ""16:00"",
		""columns"": [""l17mul3hd1e"", ""CL-201"", ""tuje"", ""Elective"", """", """"]
	}, {
		""id"": ""73747"",
		""startdate"": ""2017-10-30"",
		""starttime"": ""12:30"",
		""enddate"": ""2017-10-30"",
		""endtime"": ""16:00"",
		""columns"": [""l17ino1ae"", ""CL-164/66D"", ""pbj, runa"", ""Investor Pitch"", """", ""This day is a further extended and in-depth workout session of the training from Pitch Workshop 1, the feedback from this workshop, the reflections from the masterclass with Bill Aulet and the task given from Workshop 1: Focus on the investor part and in""]
	}, {
		""id"": ""78294"",
		""startdate"": ""2017-10-30"",
		""starttime"": ""12:30"",
		""enddate"": ""2017-10-30"",
		""endtime"": ""16:00"",
		""columns"": [""l17mak3rm1e"", ""CL-305"", ""carb, jch"", """", """", ""Jan Borg Guest teaching.""]
	}, {
		""id"": ""62277"",
		""startdate"": ""2017-10-30"",
		""starttime"": ""17:00"",
		""enddate"": ""2017-10-30"",
		""endtime"": ""20:00"",
		""columns"": [""l17acok3pab1"", ""CL-162"", ""tnc"", ""Coaching/konflikthåndtering"", ""Undervisning"", """"]
	}, {
		""id"": ""66030"",
		""startdate"": ""2017-10-30"",
		""starttime"": ""17:00"",
		""enddate"": ""2017-10-30"",
		""endtime"": ""20:00"",
		""columns"": [""l17dpl24pab1"", ""CL-101"", ""pin"", ""Det personlige lederskab 2"", ""Undervisning"", """"]
	}, {
		""id"": ""69336"",
		""startdate"": ""2017-10-31"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-10-31"",
		""endtime"": ""12:00"",
		""columns"": [""l17dat1ce"", ""CL-262"", ""tm"", ""Modul 3"", """", """"]
	}, {
		""id"": ""70082"",
		""startdate"": ""2017-10-31"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-10-31"",
		""endtime"": ""12:00"",
		""columns"": [""l17dat2ae"", ""CL-101"", """", """", """", """"]
	}, {
		""id"": ""70927"",
		""startdate"": ""2017-10-31"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-10-31"",
		""endtime"": ""12:00"",
		""columns"": [""l17mul1ae"", ""CL-266 D"", """", ""Vejledning"", ""Projekt"", """"]
	}, {
		""id"": ""72295"",
		""startdate"": ""2017-10-31"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-10-31"",
		""endtime"": ""12:00"",
		""columns"": [""l17mul3hd1e"", ""CL-201"", ""moro"", ""Elective"", """", """"]
	}, {
		""id"": ""74269"",
		""startdate"": ""2017-10-31"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-10-31"",
		""endtime"": ""12:00"",
		""columns"": [""l17fic3ae, l17fic3be"", ""CL-364 D"", ""amha"", ""Project"", ""Vejledning"", """"]
	}, {
		""id"": ""77342"",
		""startdate"": ""2017-10-31"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-10-31"",
		""endtime"": ""12:00"",
		""columns"": [""l17mak3rm1e"", """", """", """", ""Projectwork"", """"]
	}, {
		""id"": ""73723"",
		""startdate"": ""2017-10-31"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-10-31"",
		""endtime"": ""16:00"",
		""columns"": [""l17ine1ue, l17ino1be"", ""CL-164/66D"", ""pbj, runa"", ""Spring Board"", """", ""Springboard seesion with minimum 3 external board members""]
	}, {
		""id"": ""73951"",
		""startdate"": ""2017-10-31"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-10-31"",
		""endtime"": ""16:00"",
		""columns"": [""l17spm1ue, l17spo1ae"", ""CL-301"", ""bonn, crsc, sic"", ""Marketing, Project Work, Self study"", """", ""Independent study. Room 3.01 is booked - first come first serve. Simon, Carla & Maria available in the teachers office or via email. Hand-in 23:59 in Moodle.""]
	}, {
		""id"": ""66188"",
		""startdate"": ""2017-10-31"",
		""starttime"": ""09:00"",
		""enddate"": ""2017-10-31"",
		""endtime"": ""15:00"",
		""columns"": [""l17dlo24pab1"", ""CL-160 Partners  man-tor"", ""pin"", ""Ledelse og organisation 2"", ""Undervisning"", """"]
	}, {
		""id"": ""69190"",
		""startdate"": ""2017-10-31"",
		""starttime"": ""12:30"",
		""enddate"": ""2017-10-31"",
		""endtime"": ""16:00"",
		""columns"": [""l17dat1ae"", ""CL-262"", ""roda"", ""Modul 3"", """", """"]
	}, {
		""id"": ""69409"",
		""startdate"": ""2017-10-31"",
		""starttime"": ""12:30"",
		""enddate"": ""2017-10-31"",
		""endtime"": ""16:00"",
		""columns"": [""l17dat4ap1e"", ""CL-101"", ""borg"", ""App development"", """", """"]
	}, {
		""id"": ""69920"",
		""startdate"": ""2017-10-31"",
		""starttime"": ""12:30"",
		""enddate"": ""2017-10-31"",
		""endtime"": ""16:00"",
		""columns"": [""l17dat3ae"", ""CL-103"", ""tha"", ""Modul 3"", """", """"]
	}, {
		""id"": ""70829"",
		""startdate"": ""2017-10-31"",
		""starttime"": ""12:30"",
		""enddate"": ""2017-10-31"",
		""endtime"": ""16:00"",
		""columns"": [""l17wed1ve"", ""CL-266 D"", ""tor"", """", """", """"]
	}, {
		""id"": ""74267"",
		""startdate"": ""2017-10-31"",
		""starttime"": ""12:30"",
		""enddate"": ""2017-10-31"",
		""endtime"": ""16:00"",
		""columns"": [""l17fic3ae"", ""CL-364 D"", """", ""Project"", ""Arbejde selv"", """"]
	}, {
		""id"": ""69193"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""12:00"",
		""columns"": [""l17dat1ae, l17dat1be"", ""CL-205, CL-262"", ""tm"", ""Modul 3"", """", """"]
	}, {
		""id"": ""69433"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""12:00"",
		""columns"": [""l17dat4ja1e"", ""CL-101"", ""lam"", ""JavaScript"", """", """"]
	}, {
		""id"": ""69923"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""12:00"",
		""columns"": [""l17dat3ae"", ""CL-103"", ""tha"", ""Modul 3"", """", """"]
	}, {
		""id"": ""70799"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""12:00"",
		""columns"": [""l17wed1ve"", ""CL-266 D"", ""moro"", ""Database"", """", """"]
	}, {
		""id"": ""71564"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""12:00"",
		""columns"": [""l17sou1ae, l17sou2ae"", ""CL-203"", ""rhp"", ""Systemintegration"", """", """"]
	}, {
		""id"": ""74271"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""12:00"",
		""columns"": [""l17fic3ae, l17fic3be"", ""CL-305"", """", ""Project"", ""Arbejde selv"", """"]
	}, {
		""id"": ""73729"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""16:00"",
		""columns"": [""l17ino1ae"", ""CL-164/66D"", ""pbj, runa"", ""Spring Board"", """", ""Springboard seesion with minimum 3 external board members""]
	}, {
		""id"": ""73954"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""08:30"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""16:00"",
		""columns"": [""l17spm1ue, l17spo1ae"", ""CL-301"", ""bonn, crsc"", ""Project Work"", """", ""Preparation for presentation. Carla and Maria available for questions.""]
	}, {
		""id"": ""61488"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""09:00"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""15:00"",
		""columns"": [""l17dlm24pab1"", ""CL-160 Partners  man-tor"", ""pin"", ""Ledelse og medarbejdere 2"", ""Undervisning"", """"]
	}, {
		""id"": ""77935"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""12:30"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""14:00"",
		""columns"": [""l17cos5ve, l17dat5ae, l17dat5be"", ""CL-312 Open learning"", """", """", """", """"]
	}, {
		""id"": ""70152"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""12:30"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""16:00"",
		""columns"": [""l17dat2ae"", ""CL-105"", ""koe, tha"", ""Modul 4"", """", """"]
	}, {
		""id"": ""70938"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""12:30"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""16:00"",
		""columns"": [""l17mul1ae"", ""CL-266 D"", ""dsk"", ""Vejledning"", ""Projekt"", """"]
	}, {
		""id"": ""71529"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""12:30"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""16:00"",
		""columns"": [""l17dat1ce"", ""CL-262"", ""tm"", ""Modul 3"", """", """"]
	}, {
		""id"": ""71565"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""12:30"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""16:00"",
		""columns"": [""l17sod2ue"", ""CL-203"", ""rhp"", ""Systemintegration"", """", """"]
	}, {
		""id"": ""72301"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""12:30"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""16:00"",
		""columns"": [""l17mul3hd1e"", ""CL-201"", ""tuje"", ""Elective"", """", """"]
	}, {
		""id"": ""77936"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""14:30"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""16:00"",
		""columns"": [""l17sod3ve"", ""CL-312 Open learning"", ""chu"", ""Bachelorprojekt"", """", """"]
	}, {
		""id"": ""61624"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""17:00"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""20:00"",
		""columns"": [""l17alip3pab1"", ""CL-160 Partners  man-tor"", ""ct"", ""Ledelse i Praksis"", ""Undervisning"", """"]
	}, {
		""id"": ""61778"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""17:00"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""20:00"",
		""columns"": [""l17aoap3pab1"", ""CL-162"", ""npou"", ""Organisation/arbejdspsykologi"", ""Undervisning"", """"]
	}, {
		""id"": ""66618"",
		""startdate"": ""2017-11-01"",
		""starttime"": ""17:00"",
		""enddate"": ""2017-11-01"",
		""endtime"": ""20:00"",
		""columns"": [""l17dprl4pab1"", ""CL-205"", ""jens"", ""Projektledelse"", ""Undervisning"", """"]
	}]}";


        public string GetJSON()
        {
            return skema;
        }
    }


}
