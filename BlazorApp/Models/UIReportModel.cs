using DataAccessLibrary.Models;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using static BlazorApp.Models.ComponentCondition;

namespace BlazorApp.Models
{
	public class UIReportModel : IReportModel
	{
			public DateTime TimeStarted { get; set; }

			public DateTime TimeFinished { get; set; }

			public int VehicleID { get; set; }

			public int MechanicID { get; set; }

			public int AppointmentID { get; set; }

			public DateTime Date { get; set; }

			[Required]
			[Range(1, 999999)]
			public int Odometer { get; set; }

			public string RoadTestComments { get; set; }

			public string GeneralComments { get; set; }

			public string StoredFaultCodes { get; set; }

			[Required]
			public string AirConditioning { get; set; }

			[Required]
			public string Lights { get; set; }

			public string LightsComments { get; set; }

			[Required]
			public string FrontWipers { get; set; }

			public string RearWiper { get; set; }

			[Required]
			public string Battery { get; set; }

			public string BatteryComments { get; set; }

			[Required]
			public string RHFTyre { get; set; }

			[Required]
			public string LHFTyre { get; set; }

			[Required]
			public string RHRTyre { get; set; }

			[Required]
			public string LHRTyre { get; set; }

			public string TyresComments { get; set; }

			[Required]
			public bool NeedsAlignment { get; set; }

			[Required]
			public string AirFilter { get; set; }

			[Required]
			public string CabinFilter { get; set; }

			[Required]
			public string DriveBelts { get; set; }

			public string TimingBelt { get; set; }

			[Required]
			public string Radiator { get; set; }

			[Required]
			public string Hoses { get; set; }

			public string HosesComments { get; set; }

			[Required]
			public string EngineOil { get; set; }

			[Required]
			public string Coolant { get; set; }

			[Required]
			public string BrakeFluid { get; set; }

			[Required]
			public string PowerSteeringFluid { get; set; }

			[Required]
			public string TransmissionFluid { get; set; }

			[Required]
			public string WindscreenWasherFluid { get; set; }

			public string FluidsComments { get; set; }

			public string SparkPlugs { get; set; }

			[Required]
			public string FuelFilter { get; set; }

			[Required]
			public string FrontSuspension { get; set; }

			public string FrontSuspensionComments { get; set; }

			[Required]
			public string RearSuspension { get; set; }

			public string RearSuspensionComments { get; set; }

			[Required]
			public string FrontBrakes { get; set; }

			public string FrontBrakesComments { get; set; }

			[Required]
			public string RearBrakes { get; set; }

			public string RearBrakesComments { get; set; }

			[Required]
			public string Exhaust { get; set; }

			public string ExhaustComments { get; set; }

			[Required]
			public string Drivetrain { get; set; }

			public string DrivetrainComments { get; set; }

			[Required]
			public string OilLeaks { get; set; }

			public string OilLeaksComments { get; set; }

			[Required]
			public string CoolantLeaks { get; set; }

			public string CoolantLeaksComments { get; set; }

			public string OtherLeaksComments { get; set; }

			public string Other { get; set; }

			public string OtherInspectionComments { get; set; }
		}
}
