﻿namespace DataAccessLibrary.Models
{
	public interface IReportModel
	{
		string AirConditioning { get; set; }
		string AirFilter { get; set; }
		int AppointmentID { get; set; }
		string Battery { get; set; }
		string BatteryComments { get; set; }
		string BrakeFluid { get; set; }
		string CabinFilter { get; set; }
		string Coolant { get; set; }
		string CoolantLeaks { get; set; }
		string CoolantLeaksComments { get; set; }
		DateTime Date { get; set; }
		string DriveBelts { get; set; }
		string Drivetrain { get; set; }
		string DrivetrainComments { get; set; }
		string EngineOil { get; set; }
		string Exhaust { get; set; }
		string ExhaustComments { get; set; }
		string FluidsComments { get; set; }
		string FrontBrakes { get; set; }
		string FrontBrakesComments { get; set; }
		string FrontSuspension { get; set; }
		string FrontSuspensionComments { get; set; }
		string FrontWipers { get; set; }
		string FuelFilter { get; set; }
		string GeneralComments { get; set; }
		string Hoses { get; set; }
		string HosesComments { get; set; }
		string LHFTyre { get; set; }
		string LHRTyre { get; set; }
		string Lights { get; set; }
		string LightsComments { get; set; }
		int MechanicID { get; set; }
		bool NeedsAlignment { get; set; }
		int Odometer { get; set; }
		string OilLeaks { get; set; }
		string OilLeaksComments { get; set; }
		string Other { get; set; }
		string OtherInspectionComments { get; set; }
		string OtherLeaksComments { get; set; }
		string PowerSteeringFluid { get; set; }
		string Radiator { get; set; }
		string RearBrakes { get; set; }
		string RearBrakesComments { get; set; }
		string RearSuspension { get; set; }
		string RearSuspensionComments { get; set; }
		string RearWiper { get; set; }
		string RHFTyre { get; set; }
		string RHRTyre { get; set; }
		string RoadTestComments { get; set; }
		string SparkPlugs { get; set; }
		string StoredFaultCodes { get; set; }
		DateTime TimeFinished { get; set; }
		DateTime TimeStarted { get; set; }
		string TimingBelt { get; set; }
		string TransmissionFluid { get; set; }
		string TyresComments { get; set; }
		int VehicleID { get; set; }
		string WindscreenWasherFluid { get; set; }
	}
}