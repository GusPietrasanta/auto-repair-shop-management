﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
	internal class ReportModel : IReportModel
	{
		public int ID { get; set; }
		public DateTime TimeStarted { get; set; }

		public DateTime TimeFinished { get; set; }

		public int VehicleID { get; set; }

		public int MechanicID { get; set; }
		public int AppointmentID { get; set; }
		public int CustomerID { get; set; }

		public DateTime Date { get; set; }

		public int Odometer { get; set; }

		public string RoadTestComments { get; set; }

		public string GeneralComments { get; set; }

		public string StoredFaultCodes { get; set; }

		public string AirConditioning { get; set; }

		public string Lights { get; set; }

		public string LightsComments { get; set; }

		public string FrontWipers { get; set; }

		public string RearWiper { get; set; }

		public string Battery { get; set; }

		public string BatteryComments { get; set; }

		public string RHFTyre { get; set; }

		public string LHFTyre { get; set; }

		public string RHRTyre { get; set; }

		public string LHRTyre { get; set; }

		public string TyresComments { get; set; }

		public bool NeedsAlignment { get; set; }

		public string AirFilter { get; set; }

		public string CabinFilter { get; set; }

		public string DriveBelts { get; set; }

		public string TimingBelt { get; set; }

		public string Radiator { get; set; }

		public string Hoses { get; set; }

		public string HosesComments { get; set; }

		public string EngineOil { get; set; }

		public string Coolant { get; set; }

		public string BrakeFluid { get; set; }

		public string PowerSteeringFluid { get; set; }

		public string TransmissionFluid { get; set; }

		public string WindscreenWasherFluid { get; set; }

		public string FluidsComments { get; set; }

		public string SparkPlugs { get; set; }

		public string FuelFilter { get; set; }

		public string FrontSuspension { get; set; }

		public string FrontSuspensionComments { get; set; }

		public string RearSuspension { get; set; }

		public string RearSuspensionComments { get; set; }

		public string FrontBrakes { get; set; }

		public string FrontBrakesComments { get; set; }

		public string RearBrakes { get; set; }

		public string RearBrakesComments { get; set; }

		public string Exhaust { get; set; }

		public string ExhaustComments { get; set; }

		public string Drivetrain { get; set; }

		public string DrivetrainComments { get; set; }

		public string OilLeaks { get; set; }

		public string OilLeaksComments { get; set; }

		public string CoolantLeaks { get; set; }

		public string CoolantLeaksComments { get; set; }

		public string OtherLeaksComments { get; set; }

		public string Other { get; set; }

		public string OtherInspectionComments { get; set; }
	}
}